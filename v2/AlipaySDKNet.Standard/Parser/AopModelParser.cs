﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aop.Api;
using System.Reflection;
using System.Collections;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Parser
{
    public class AopModelParser
    {

        /// <summary>
        /// Json序列化AopObject对象
        /// </summary>
        /// <param name="res"></param>
        /// <returns></returns>
        public IDictionary<object, object> serializeAopObject(AopObject res)
        {
            PropertyInfo[] pis = res.GetType().GetProperties();
            IDictionary<object, object> jo = new Dictionary<object, object>();
            foreach (PropertyInfo pi in pis)
            {
                if (!pi.CanRead)
                {
                    continue;
                }

                String elementName = getElementName(pi);
                Object value = getPiValue(res, pi);
                if (!String.IsNullOrEmpty(elementName))
                {
                    Object serialized = serializeValue(value);
                    if (serialized != null)
                    {
                        jo[elementName] = serialized;
                    }
                }
            }

            return jo;
        }

        /// <summary>
        /// 序列化某个对象
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private Object serializeValue(Object value)
        {
            if (value == null)
            {
                return null;
            }

            Object result = null;
            if (value is IDictionary)
            {
                result = serializeDicValue((IDictionary)value);
            }
            else if (value is ICollection)
            {
                result = serializeArrayValue((ICollection)value);
            }
            else
            {
                result = serializeElementValue(value);
            }
            return result;
        }

        /// <summary>
        /// 序列化一个元素
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private Object serializeElementValue(Object value)
        {
            if (value == null)
            {
                return null;
            }

            Object result = null;
            if (value is AopObject)
            {
                result = serializeAopObject((AopObject)value);
            }
            else
            {
                result = value;
            }
            return result;
        }

        /// <summary>
        /// 序列化一个字典
        /// </summary>
        /// <param name="dic"></param>
        /// <returns></returns>
        private Object serializeDicValue(IDictionary dic)
        {
            if (dic == null)
            {
                return null;
            }

            IDictionary<object, object> jo = new Dictionary<object, object>();
            foreach (String key in dic.Keys)
            {
                Object dicValue = dic[key];
                Object serializedValue = serializeValue(dicValue);
                jo[key] = serializedValue;
            }
            return jo;
        }

        /// <summary>
        /// 序列化一个数组
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        public Object serializeArrayValue(ICollection collection)
        {
            if (collection == null)
            {
                return null;
            }

            List<object> ja = new List<object>();
            foreach (var item in collection)
            {
                ja.Add(serializeValue(item));
            }
            return ja;
        }

        /// <summary>
        /// 获取对象的属性值
        /// </summary>
        /// <param name="res"></param>
        /// <param name="pi"></param>
        /// <returns></returns>
        private Object getPiValue(Object res, PropertyInfo pi)
        {
            if (!pi.CanRead)
            {
                return null;
            }

            Object value = pi.GetValue(res, null);
            return value;
        }

        /// <summary>
        /// 获取Xml属性名
        /// </summary>
        /// <param name="pi"></param>
        /// <returns></returns>
        private String getElementName(PropertyInfo pi)
        {
            if (pi == null)
            {
                return null;
            }

            // 获取XmlElement属性
            XmlElementAttribute[] xeas = pi.GetCustomAttributes(typeof(XmlElementAttribute), true) as XmlElementAttribute[];
            String elementName = null;
            if (xeas != null && xeas.Length > 0)
            {
                elementName = xeas[0].ElementName;
            }

            // 如果获取XmlElement属性为空，则去获取XmlArray属性
            if (String.IsNullOrEmpty(elementName))
            {
                XmlArrayAttribute[] xaas = pi.GetCustomAttributes(typeof(XmlArrayAttribute), true) as XmlArrayAttribute[];
                if (xaas != null && xaas.Length > 0)
                {
                    elementName = xaas[0].ElementName;
                }
            }
            return elementName;
        }

    }
}
