using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodAssetapplyQueryResponse.
    /// </summary>
    public class AlipayCommerceIotMdeviceprodAssetapplyQueryResponse : AopResponse
    {
        /// <summary>
        /// 申请的服务商名称；  内部接口，给供应商系统调用
        /// </summary>
        [XmlElement("apply_isv_name")]
        public string ApplyIsvName { get; set; }

        /// <summary>
        /// 申请的服务商的PID
        /// </summary>
        [XmlElement("apply_isv_pid")]
        public string ApplyIsvPid { get; set; }

        /// <summary>
        /// 申请商户的手机  内部接口，给供应商系统使用
        /// </summary>
        [XmlElement("apply_merchant_mobile")]
        public string ApplyMerchantMobile { get; set; }

        /// <summary>
        /// 申请商户的名称;  内部接口，给供应商系统调用
        /// </summary>
        [XmlElement("apply_merchant_name")]
        public string ApplyMerchantName { get; set; }

        /// <summary>
        /// 申请商户的PID
        /// </summary>
        [XmlElement("apply_merchant_pid")]
        public string ApplyMerchantPid { get; set; }

        /// <summary>
        /// 物料申请人手机号；  内部接口，给供应商使用；
        /// </summary>
        [XmlElement("apply_person_mobile")]
        public string ApplyPersonMobile { get; set; }

        /// <summary>
        /// 物料申请人的名字；  内部使用接口，给供应商平台调用，需要展示申请人姓名
        /// </summary>
        [XmlElement("apply_person_name")]
        public string ApplyPersonName { get; set; }

        /// <summary>
        /// 扩展字段: 内部接口，给供应商系统调用
        /// </summary>
        [XmlElement("detail_info")]
        public string DetailInfo { get; set; }

        /// <summary>
        /// 首次申请标识: 内部接口，给供应商系统调用
        /// </summary>
        [XmlElement("first_apply")]
        public bool FirstApply { get; set; }

        /// <summary>
        /// 申请店铺id: 内部接口，给供应商系统调用
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 申请店铺名: 内部接口，给供应商系统调用
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }
    }
}
