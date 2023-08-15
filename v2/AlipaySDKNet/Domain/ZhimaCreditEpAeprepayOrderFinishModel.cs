using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpAeprepayOrderFinishModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpAeprepayOrderFinishModel : AopObject
    {
        /// <summary>
        /// 预留扩展
        /// </summary>
        [XmlElement("ext_param")]
        public ZmEpAePrepayExtParam ExtParam { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        [XmlElement("order_num")]
        public string OrderNum { get; set; }

        /// <summary>
        /// 审核单创建时间戳
        /// </summary>
        [XmlElement("order_time_millis")]
        public string OrderTimeMillis { get; set; }

        /// <summary>
        /// 商家登陆id
        /// </summary>
        [XmlElement("seller_login_id")]
        public string SellerLoginId { get; set; }
    }
}
