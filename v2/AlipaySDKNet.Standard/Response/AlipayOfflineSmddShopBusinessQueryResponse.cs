using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineSmddShopBusinessQueryResponse.
    /// </summary>
    public class AlipayOfflineSmddShopBusinessQueryResponse : AopResponse
    {
        /// <summary>
        /// 营业状态 IN_BUSINESS（营业中）/OUT_OF_BUSINESS（暂停营业）
        /// </summary>
        [XmlElement("business_status")]
        public string BusinessStatus { get; set; }

        /// <summary>
        /// 营业时间文案，透出营业时间给C用户查看
        /// </summary>
        [XmlElement("business_time_desc")]
        public string BusinessTimeDesc { get; set; }

        /// <summary>
        /// 营业时间列表，多段营业时间。该字段不存在表示全天营业
        /// </summary>
        [XmlArray("business_time_list")]
        [XmlArrayItem("business_time_bean")]
        public List<BusinessTimeBean> BusinessTimeList { get; set; }

        /// <summary>
        /// 当营业状态处于营业中时，判断当前是否是否处于营业时间内
        /// </summary>
        [XmlElement("business_time_rest")]
        public bool BusinessTimeRest { get; set; }
    }
}
