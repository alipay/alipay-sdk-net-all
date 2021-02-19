using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandItemOpenQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandItemOpenQueryModel : AopObject
    {
        /// <summary>
        /// 场景码（具体值请参见产品文档）。 小程序订单中心场景固定为 APP_ORDER。
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 商品状态：EFFECT（有效）、INVALID（无效）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 商品归属主体ID 例：商品归属主体类型target_type为店铺，则商品归属主体ID为店铺ID（支付宝侧店铺ID）；归属主体类型target_type为小程序，则归属主体ID为小程序ID
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 商品归属主体类型。枚举如下： 5：店铺。 8：小程序。
        /// </summary>
        [XmlElement("target_type")]
        public string TargetType { get; set; }
    }
}
