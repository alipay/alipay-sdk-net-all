using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiMerchantActivityOnlineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiMerchantActivityOnlineModel : AopObject
    {
        /// <summary>
        /// 商家活动ID，用于唯一确定一个活动
        /// </summary>
        [XmlElement("aggr_id")]
        public string AggrId { get; set; }

        /// <summary>
        /// 外部请求号,用于幂等管理
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
