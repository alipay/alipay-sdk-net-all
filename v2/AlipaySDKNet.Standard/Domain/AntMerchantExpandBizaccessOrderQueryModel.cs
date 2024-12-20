using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandBizaccessOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandBizaccessOrderQueryModel : AopObject
    {
        /// <summary>
        /// 表示服务商代商户开通业务申请单的主单号（必填，本期仅支持使用order_id查询）
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户id（本期不支持使用pid查询）
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}
