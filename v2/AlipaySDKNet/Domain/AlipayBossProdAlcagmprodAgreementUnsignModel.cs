using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdAlcagmprodAgreementUnsignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdAlcagmprodAgreementUnsignModel : AopObject
    {
        /// <summary>
        /// 法务C端协议分配的协议ID，用于唯一标识一个协议或复用协议。支持列表(批量签约)
        /// </summary>
        [XmlArray("agreement_id_list")]
        [XmlArrayItem("string")]
        public List<string> AgreementIdList { get; set; }

        /// <summary>
        /// 解约日期，yyyy-MM-dd HH:mm:ss.
        /// </summary>
        [XmlElement("cancel_date")]
        public string CancelDate { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 一般是户号/订单号/2088等； 1、签约与解约保持一致； 2、与离线口径的签约Id保持一致；
        /// </summary>
        [XmlElement("out_sign_no")]
        public string OutSignNo { get; set; }

        /// <summary>
        /// 产品码（产品星球）
        /// </summary>
        [XmlElement("product_cd")]
        public string ProductCd { get; set; }

        /// <summary>
        /// 来源系统名，即发起调用的系统英文名称
        /// </summary>
        [XmlElement("request_from")]
        public string RequestFrom { get; set; }

        /// <summary>
        /// 本次请求流水号，用于幂等 (幂等机制：user_id + product_cd + out_sign_no + request_no + agreement_id_list唯一确定)
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
