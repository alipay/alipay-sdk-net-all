using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpNordermaterialsapplyMaterialsrecordSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpNordermaterialsapplyMaterialsrecordSyncModel : AopObject
    {
        /// <summary>
        /// 门店提报/一次性场景必填
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 门店信息二选一：地址5要素之一
        /// </summary>
        [XmlElement("area")]
        public string Area { get; set; }

        /// <summary>
        /// 门店信息二选一：地址5要素之一
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 门店信息二选一：地址5要素之一
        /// </summary>
        [XmlElement("detail_address")]
        public string DetailAddress { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("file_id_list")]
        [XmlArrayItem("string")]
        public List<string> FileIdList { get; set; }

        /// <summary>
        /// null
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
        /// 门店信息二选一：地址5要素之一
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 返佣pid
        /// </summary>
        [XmlElement("rebate_pid")]
        public string RebatePid { get; set; }

        /// <summary>
        /// 视频送审场景必填（阶段一/一次性出参返回），唯一标识一个门店
        /// </summary>
        [XmlElement("shop_biz_id")]
        public string ShopBizId { get; set; }

        /// <summary>
        /// 门店信息二选一：传shop_id 或 传地址5要素（省+市+区+详细地址+门店名称）
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 门店信息二选一：地址5要素之一
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// saas_ka场景必填
        /// </summary>
        [XmlElement("shop_order_no")]
        public string ShopOrderNo { get; set; }
    }
}
