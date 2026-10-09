using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantOrderSnstradeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantOrderSnstradeQueryModel : AopObject
    {
        /// <summary>
        /// 物料售卖接入id
        /// </summary>
        [XmlElement("asset_access_id")]
        public string AssetAccessId { get; set; }

        /// <summary>
        /// 日期精确到天
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 渠道编码
        /// </summary>
        [XmlElement("ch_info")]
        public string ChInfo { get; set; }
    }
}
