using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpNordermaterialsapplyShopCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpNordermaterialsapplyShopCreateModel : AopObject
    {
        /// <summary>
        /// 创建申请单时，返回的申请单ID
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 门店所处区县
        /// </summary>
        [XmlElement("area")]
        public string Area { get; set; }

        /// <summary>
        /// 门店所处城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 物料快递收货地址，用于后续接收物料的快递
        /// </summary>
        [XmlElement("delivery_address")]
        public string DeliveryAddress { get; set; }

        /// <summary>
        /// 门店所处的具体详细地址
        /// </summary>
        [XmlElement("detail_address")]
        public string DetailAddress { get; set; }

        /// <summary>
        /// 门店所属的商户名称，如果没有可以与门店名同名
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 支付宝上对应的点餐小程序ID
        /// </summary>
        [XmlElement("order_app_id")]
        public string OrderAppId { get; set; }

        /// <summary>
        /// 用于判断门店的幂等标识
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 门店所处的省份
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 返佣pid，在带有门店信息下支持提前落位，否则仍然需要在后面铺设回传时传递
        /// </summary>
        [XmlElement("rebate_pid")]
        public string RebatePid { get; set; }

        /// <summary>
        /// 收件人姓名，用于后续接收物料的快递
        /// </summary>
        [XmlElement("receiver_name")]
        public string ReceiverName { get; set; }

        /// <summary>
        /// 收件人电话，用于后续接收物料的快递
        /// </summary>
        [XmlElement("receiver_phone")]
        public string ReceiverPhone { get; set; }

        /// <summary>
        /// 填写蚂蚁体系的门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }
    }
}
