using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechNftAssetNftidCheckResponse.
    /// </summary>
    public class AnttechNftAssetNftidCheckResponse : AopResponse
    {
        /// <summary>
        /// 是否支持转增
        /// </summary>
        [XmlElement("nft_enable_send")]
        public bool NftEnableSend { get; set; }

        /// <summary>
        /// OWNING(1, "待持有")OWNED(2, "已持有"),RELEASING(3, "待释放"),RELEASED(4, "已释放"),CANCELLED(5, "已取消"),
        /// </summary>
        [XmlElement("own_status")]
        public long OwnStatus { get; set; }

        /// <summary>
        /// 流转时间，只有资产2或者3时才会有
        /// </summary>
        [XmlElement("receive_time")]
        public string ReceiveTime { get; set; }
    }
}
