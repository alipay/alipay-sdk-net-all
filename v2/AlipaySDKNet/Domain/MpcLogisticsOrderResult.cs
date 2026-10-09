using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MpcLogisticsOrderResult Data Structure.
    /// </summary>
    [Serializable]
    public class MpcLogisticsOrderResult : AopObject
    {
        /// <summary>
        /// 物流公司代码
        /// </summary>
        [XmlElement("logistics_company_code")]
        public string LogisticsCompanyCode { get; set; }

        /// <summary>
        /// 物流公司名称
        /// </summary>
        [XmlElement("logistics_company_name")]
        public string LogisticsCompanyName { get; set; }

        /// <summary>
        /// 物流详情
        /// </summary>
        [XmlArray("logistics_detail_list")]
        [XmlArrayItem("mpc_logistics_detail")]
        public List<MpcLogisticsDetail> LogisticsDetailList { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        [XmlElement("mail_no")]
        public string MailNo { get; set; }
    }
}
