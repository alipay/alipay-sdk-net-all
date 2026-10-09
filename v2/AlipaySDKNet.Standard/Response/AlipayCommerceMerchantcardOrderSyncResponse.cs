using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMerchantcardOrderSyncResponse.
    /// </summary>
    public class AlipayCommerceMerchantcardOrderSyncResponse : AopResponse
    {
        /// <summary>
        /// 数据同步响应模型，返回数据同步任务处理的结果
        /// </summary>
        [XmlElement("data_sync_rep")]
        public DataSyncResponse DataSyncRep { get; set; }
    }
}
