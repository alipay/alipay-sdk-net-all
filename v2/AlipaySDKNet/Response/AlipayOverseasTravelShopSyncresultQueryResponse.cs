using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTravelShopSyncresultQueryResponse.
    /// </summary>
    public class AlipayOverseasTravelShopSyncresultQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前店铺业务状态。NORMAL：正常开业中；CLOSED ：已停业
        /// </summary>
        [XmlElement("shop_biz_status")]
        public string ShopBizStatus { get; set; }

        /// <summary>
        /// 店铺信息处理失败的错误码，如转链错误，风控审核错误等
        /// </summary>
        [XmlElement("sync_failed_code")]
        public string SyncFailedCode { get; set; }

        /// <summary>
        /// 店铺信息处理失败时的错误描述
        /// </summary>
        [XmlElement("sync_failed_msg")]
        public string SyncFailedMsg { get; set; }

        /// <summary>
        /// 同步返回的请求处理结果。PROCESSING：处理中；SUCCESS:处理成功；FAILED:处理失败。 轮询查询时基于此结果判断店铺是否同步成功。
        /// </summary>
        [XmlElement("sync_status")]
        public string SyncStatus { get; set; }
    }
}
