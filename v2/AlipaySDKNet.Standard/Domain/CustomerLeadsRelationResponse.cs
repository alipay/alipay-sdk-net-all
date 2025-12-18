using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CustomerLeadsRelationResponse Data Structure.
    /// </summary>
    [Serializable]
    public class CustomerLeadsRelationResponse : AopObject
    {
        /// <summary>
        /// 海图客户归属BD花名
        /// </summary>
        [XmlElement("bd_nick_name")]
        public string BdNickName { get; set; }

        /// <summary>
        /// 海图客户归属BD工号
        /// </summary>
        [XmlElement("bd_work_no")]
        public string BdWorkNo { get; set; }

        /// <summary>
        /// 客户唯一实体id
        /// </summary>
        [XmlElement("bid")]
        public string Bid { get; set; }

        /// <summary>
        /// 海图客户编码
        /// </summary>
        [XmlElement("cid")]
        public string Cid { get; set; }

        /// <summary>
        /// 海图客户名称
        /// </summary>
        [XmlElement("customer_name")]
        public string CustomerName { get; set; }

        /// <summary>
        /// 客户常用名
        /// </summary>
        [XmlElement("customer_short_name")]
        public string CustomerShortName { get; set; }

        /// <summary>
        /// 海图客户归属BD所属团队名称
        /// </summary>
        [XmlElement("dept_name")]
        public string DeptName { get; set; }

        /// <summary>
        /// 海图客户归属BD所属团队编码
        /// </summary>
        [XmlElement("dept_no")]
        public string DeptNo { get; set; }

        /// <summary>
        /// 客户id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 关联商机编码
        /// </summary>
        [XmlElement("leads_code")]
        public string LeadsCode { get; set; }

        /// <summary>
        /// 官网uid
        /// </summary>
        [XmlElement("passport_id")]
        public string PassportId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("passport_id_list")]
        [XmlArrayItem("string")]
        public List<string> PassportIdList { get; set; }

        /// <summary>
        /// 渠道uid
        /// </summary>
        [XmlElement("platform_uid")]
        public string PlatformUid { get; set; }
    }
}
