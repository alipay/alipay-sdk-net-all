using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantEvisaStatusSyncResponse.
    /// </summary>
    public class ZhimaMerchantEvisaStatusSyncResponse : AopResponse
    {
        /// <summary>
        /// 商户生成唯一的外部接口调用事务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
