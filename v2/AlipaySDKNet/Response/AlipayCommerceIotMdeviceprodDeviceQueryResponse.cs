using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodDeviceQueryResponse.
    /// </summary>
    public class AlipayCommerceIotMdeviceprodDeviceQueryResponse : AopResponse
    {
        /// <summary>
        /// 机具绑定状态  "BIND"--已绑定  "UNBIND"--未绑定
        /// </summary>
        [XmlElement("bind_status")]
        public string BindStatus { get; set; }

        /// <summary>
        /// 设备id,支付宝内生产的设备唯一id
        /// </summary>
        [XmlElement("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 设备使用业务场景:  团餐机具  快消机具  未来校园  K12  长尾机具  智能售卖  公交机具  客运机具  餐饮机具  政务机具  医疗机具
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 机具所属ISV的ID
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 物料id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 机具绑定的商户id
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 机具绑定的使用门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 机具状态，  "UNREGISTER" -- 未注册  "ACTIVED" -- 已激活  "UNACTIVED" -- 未激活
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 机具供应商id
        /// </summary>
        [XmlElement("supplier_sn")]
        public string SupplierSn { get; set; }
    }
}
