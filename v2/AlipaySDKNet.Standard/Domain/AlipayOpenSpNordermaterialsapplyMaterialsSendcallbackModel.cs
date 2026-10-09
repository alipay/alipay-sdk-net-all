using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpNordermaterialsapplyMaterialsSendcallbackModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpNordermaterialsapplyMaterialsSendcallbackModel : AopObject
    {
        /// <summary>
        /// 申请单ID，等同创建申请单返回的ID
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 铺设门店所在区县
        /// </summary>
        [XmlElement("area")]
        public string Area { get; set; }

        /// <summary>
        /// 铺设门店所在城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 门店铺设所在详细地址
        /// </summary>
        [XmlElement("detail_address")]
        public string DetailAddress { get; set; }

        /// <summary>
        /// 铺设的物料信息
        /// </summary>
        [XmlArray("materials_info")]
        [XmlArrayItem("call_back_materials_info")]
        public List<CallBackMaterialsInfo> MaterialsInfo { get; set; }

        /// <summary>
        /// 铺设的门店所属商户名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 支付宝上的点餐小程序
        /// </summary>
        [XmlElement("order_app_id")]
        public string OrderAppId { get; set; }

        /// <summary>
        /// 铺设门店所属省份
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 返佣pid，用于后续返佣政策
        /// </summary>
        [XmlElement("rebate_pid")]
        public string RebatePid { get; set; }

        /// <summary>
        /// 蚂蚁体系的门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 铺设门店名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 门店单标识
        /// </summary>
        [XmlElement("shop_order_no")]
        public string ShopOrderNo { get; set; }
    }
}
