using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdStoreBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdStoreBindModel : AopObject
    {
        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 拓展信息，新增时必填 例如： {     "storeId": "门店id", // 用于幂等     "storeName": "门店名称",     "address": "门店地址详情"，     "addressExtInfo": "门店地址补充信息",     "lat": "门店纬度",     "lnt": "门店经度",     "provinceName": "门店所在省份",     "cityName": "门店所在城市",     "telephone": "联系电话",     "tradeId": "门店行业" }
        /// </summary>
        [XmlElement("extend_info")]
        public StoreExtendInfo ExtendInfo { get; set; }

        /// <summary>
        /// 商家id
        /// </summary>
        [XmlElement("principal_id")]
        public long PrincipalId { get; set; }

        /// <summary>
        /// 0 - 绑定门店 1 - 解绑门店
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 投放账户id
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }
    }
}
