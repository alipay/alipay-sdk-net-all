using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceFesSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInsuranceFesSendModel : AopObject
    {
        /// <summary>
        /// 交易时间
        /// </summary>
        [XmlElement("cur_company_id")]
        public string CurCompanyId { get; set; }

        /// <summary>
        /// 交易时间
        /// </summary>
        [XmlElement("enc_content")]
        public string EncContent { get; set; }

        /// <summary>
        /// 交易时间
        /// </summary>
        [XmlElement("enterprise_url")]
        public string EnterpriseUrl { get; set; }

        /// <summary>
        /// 交易时间
        /// </summary>
        [XmlElement("trans_date")]
        public string TransDate { get; set; }

        /// <summary>
        /// 交易时间
        /// </summary>
        [XmlElement("trans_no")]
        public string TransNo { get; set; }
    }
}
