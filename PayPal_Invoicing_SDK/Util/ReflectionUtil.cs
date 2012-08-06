using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace PayPal.Util
{
    /// <summary>
    /// Helper class for sanity tests
    /// </summary>
    public class ReflectionUtil
    {
        /// <summary>
        /// Returns a reverse NVP map from a response object using reflection
        /// </summary>
        public static Dictionary<string, string> decodeResponseObject(object responseType, string prefix)
        {
            Dictionary<string, string> returnDictionary = new Dictionary<string, string>();
            Dictionary<string, object> rDictionary = ReflectionUtil.generateMapFromResponse(responseType, "");
            if (rDictionary != null && rDictionary.Count > 0)
            {
                foreach(KeyValuePair<string, object> pair in rDictionary)
                {
                    returnDictionary.Add(pair.Key, pair.Value.ToString());
                }
                
            }
            return returnDictionary;
        }

        private static Dictionary<string, object> generateMapFromResponse(object responseType, string prefix)
        {
            if (responseType == null)
            {
                return null;
            }
            Dictionary<string, object> responseDictionary = new Dictionary<string,object>();

            Dictionary<string, object> returnDictionary;
            object returnObject;

            Type klazzType = responseType.GetType();
            MethodInfo[] methodInfo = klazzType.GetMethods();
            string nameSpace;
            string propertyName;
            foreach (MethodInfo mInfo in methodInfo)
            {
                if (mInfo.Name.StartsWith("get_"))
                {
                    nameSpace = mInfo.ReturnType.Namespace;
                    if (prefix.Length != 0)
                    {
                        propertyName = prefix + "."
                                + mInfo.Name.Substring(4);
                    }
                    else
                    {
                        propertyName = mInfo.Name.Substring(4);
                    }
                    if (nameSpace != null)
                    {
                        if (!nameSpace.StartsWith("PayPal"))
                        {
                            returnObject = mInfo.Invoke(responseType, null);
                            if (returnObject != null && returnObject.GetType().IsGenericType)
                            {
                                System.Collections.IList list = (System.Collections.IList)returnObject;
                                int i = 0;
                                foreach (object obj in list)
                                {
                                    if (obj.GetType().Namespace.StartsWith("PayPal"))
                                    {
                                        returnDictionary = generateMapFromResponse(obj, propertyName + "(" + i + ")");
                                        if (returnDictionary != null && returnDictionary.Count > 0)
                                        {
                                            foreach (KeyValuePair<string, object> entry in returnDictionary)
                                            {
                                                responseDictionary.Add(entry.Key, entry.Value);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        responseDictionary.Add(propertyName + "(" + i + ")", obj);
                                    }
                                    i++;
                                }
                            }
                            else if (returnObject != null && returnObject.GetType().IsEnum)
                            {
                                Enum e = (Enum)returnObject;
                                responseDictionary.Add(propertyName, ReflectionEnumUtil.getDescription(e));
                            }
                            else if (returnObject != null)
                            {
                                if (klazzType.Name.EndsWith("ErrorParameter") &&
                                    propertyName.EndsWith("value"))
                                {
                                    propertyName = propertyName.Substring(0, propertyName.LastIndexOf("."));
                                }
                                responseDictionary.Add(propertyName, returnObject);
                            }

                        }
                        else
                        {
                            returnObject = mInfo.Invoke(responseType, null);
                            if (returnObject != null && mInfo.ReturnType.IsEnum)
                            {
                                //To be coded
                            }
                            else if(returnObject != null)
                            {
                                returnDictionary = generateMapFromResponse(returnObject, propertyName);
                                if (returnDictionary != null && returnDictionary.Count > 0)
                                {
                                    foreach (KeyValuePair<string, object> entry in returnDictionary)
                                    {
                                        responseDictionary.Add(entry.Key, entry.Value);
                                    }
                                }

                            }
                        }

                    }
                    else
                    {
                        responseDictionary.Add(propertyName, mInfo.Invoke(responseType, null));
                    }

                }
            }
            return responseDictionary;
        }
    }
}
