using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Aop.Api.Parser
{
    /// <summary>
    /// AOP JSON响应通用读取器。
    /// </summary>
    public class AopJsonReader : IAopReader
    {
        private JObject json;

        public AopJsonReader(JObject json)
        {
            this.json = json;
        }

        public bool HasReturnField(object name)
        {
            return json.ContainsKey(name as string);
        }

        public object GetPrimitiveObject(object name)
        {
            return json[name];
        }

        public object GetReferenceObject(object name, Type type, DAopConvert convert)
        {
            JObject dict = json[name] as JObject;
            if (dict != null && dict.Count > 0)
            {
                return convert(new AopJsonReader(dict), type);
            }
            else
            {
                return null;
            }
        }

        public IList GetListObjects(string listName, string itemName, Type type, DAopConvert convert)
        {
            IList listObjs = null;

            Object jsonObject = json[listName];


            IList jsonList = null;
            if (jsonObject is IList)
            {
                jsonList = jsonObject as IList;
            }
            else if (jsonObject is IDictionary)
            {
                IDictionary jsonMap = jsonObject as IDictionary;

                if (jsonMap != null && jsonMap.Count > 0)
                {

                    Object itemTmp = jsonMap[itemName];

                    if (itemTmp == null && listName != null)
                    {
                        itemTmp = jsonMap[listName.Substring(0, listName.Length - 1)];
                    }

                    if (itemTmp is IList)
                    {
                        jsonList = itemTmp as IList;
                    }

                }
            }

            if (jsonList != null && jsonList.Count > 0)
            {
                Type listType = typeof(List<>).MakeGenericType(new Type[] { type });
                listObjs = Activator.CreateInstance(listType) as IList;
                foreach (object item in jsonList)
                {
                    if (typeof(JObject).IsAssignableFrom(item.GetType())) // object
                    {
                        JObject subMap = item as JObject;
                        object subObj = convert(new AopJsonReader(subMap), type);
                        if (subObj != null)
                        {
                            listObjs.Add(subObj);
                        }
                    }
                    else if (typeof(IList).IsAssignableFrom(item.GetType())) // list/array
                    {
                        // TODO not support yet
                    }
                    else if (typeof(long).IsAssignableFrom(type))
                    {
                        JValue tmp = item as JValue;
                        if (tmp.Value != null)
                        {
                            listObjs.Add(((IConvertible)tmp).ToInt64(null));
                        }
                        else
                        {
                            listObjs.Add(null);
                        }
                    }
                    else if (typeof(int).IsAssignableFrom(type))
                    {
                        JValue tmp = item as JValue;
                        if (tmp.Value != null)
                        {
                            listObjs.Add(((IConvertible)tmp).ToInt32(null));
                        }
                        else
                        {
                            listObjs.Add(null);
                        }
                    }
                    else if (typeof(double).IsAssignableFrom(type))
                    {
                        JValue tmp = item as JValue;
                        if (tmp.Value != null)
                        {
                            listObjs.Add(((IConvertible)tmp).ToDouble(null));
                        }
                        else
                        {
                            listObjs.Add(null);
                        }
                    }
                    else if (typeof(bool).IsAssignableFrom(type))
                    {
                        JValue tmp = item as JValue;
                        if (tmp.Value != null)
                        {
                            listObjs.Add(((IConvertible)tmp).ToBoolean(null));
                        }
                        else
                        {
                            listObjs.Add(null);
                        }
                    }
                    else if (typeof(string).IsAssignableFrom(type))
                    {
                        JValue tmp = item as JValue;
                        if (tmp.Value != null)
                        {
                            listObjs.Add(((IConvertible)tmp).ToString(null));
                        }
                        else
                        {
                            listObjs.Add(null);
                        }
                    }
                    else
                    {
                        JValue tmp = item as JValue;
                        listObjs.Add(tmp.Value);
                    }
                }

            }

            return listObjs;
        }
    }
}
