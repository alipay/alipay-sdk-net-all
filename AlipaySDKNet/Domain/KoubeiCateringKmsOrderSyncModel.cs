using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiCateringKmsOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringKmsOrderSyncModel : AopObject
    {
        /// <summary>
        /// 同步动作. "PUSH":推送订单; "CANCEL_PUSH": 取消推送
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 推单渠道码. "ELE_ME":饿了么; "KERUYUN":客如云；“YINBAO”:银豹；“DUOWEI”:"多维";如不再此名单则联系口碑技术同学新增；
        /// </summary>
        [XmlElement("biz_channel")]
        public string BizChannel { get; set; }

        /// <summary>
        /// 菜品信息列表. action=PUSH时必填, aciton=CANCEL_PUSH不填
        /// </summary>
        [XmlArray("kds_dish_info_list")]
        [XmlArrayItem("kds_dish_info_d_t_o")]
        public List<KdsDishInfoDTO> KdsDishInfoList { get; set; }

        /// <summary>
        /// 订单信息. action=PUSH时必填, aciton=CANCEL_PUSH不填
        /// </summary>
        [XmlElement("kds_order_info")]
        public KdsOrderInfoDTO KdsOrderInfo { get; set; }

        /// <summary>
        /// 口碑订单号.（口碑订单必传） 退款时, 以order_no为主. 如果order_no不存在, 以out_order_no为准.
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 口碑店铺id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 原始订单来源. ISV订单:isvpos(例如:属于客如云、银豹、多维等ISV厂商自己的POS订单，则传isvpos)； 口碑订单:koubei； 饿了么订单:eleme； 支付宝订单:alipay； 美团订单:meituan； 滴滴订单:didi； 其他平台:other；
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
