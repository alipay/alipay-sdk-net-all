using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTravelGoodsSyncresultQueryResponse.
    /// </summary>
    public class AlipayOverseasTravelGoodsSyncresultQueryResponse : AopResponse
    {
        /// <summary>
        /// 商品状态，NORMAL表示如正在售卖，CLOSED表示下架；当syncStatus为SUCCESS时该值一定存在，其他状态不一定存在。
        /// </summary>
        [XmlElement("goods_biz_status")]
        public string GoodsBizStatus { get; set; }

        /// <summary>
        /// 商品信息处理失败的错误码，如转链错误，风控审核错误等
        /// </summary>
        [XmlElement("sync_failed_code")]
        public string SyncFailedCode { get; set; }

        /// <summary>
        /// 商品信息处理失败时的错误描述
        /// </summary>
        [XmlElement("sync_failed_msg")]
        public string SyncFailedMsg { get; set; }

        /// <summary>
        /// 商品数据同步请求处理状态： SUCCESS表示成功； FAILED表示商品信息处理失败，如商品信息审核失败；PROCESSING表示商品信息处理中。
        /// </summary>
        [XmlElement("sync_status")]
        public string SyncStatus { get; set; }
    }
}
