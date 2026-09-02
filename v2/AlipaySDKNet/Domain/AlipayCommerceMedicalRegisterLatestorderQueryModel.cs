using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalRegisterLatestorderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalRegisterLatestorderQueryModel : AopObject
    {
        /// <summary>
        /// 渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单业务参数
        /// </summary>
        [XmlElement("order_prop")]
        public string OrderProp { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 每页的条数
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 机构ID
        /// </summary>
        [XmlElement("select_hos_institution_code")]
        public string SelectHosInstitutionCode { get; set; }

        /// <summary>
        /// 医院ID
        /// </summary>
        [XmlElement("select_hos_uniq_code")]
        public string SelectHosUniqCode { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("status")]
        [XmlArrayItem("string")]
        public List<string> Status { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
