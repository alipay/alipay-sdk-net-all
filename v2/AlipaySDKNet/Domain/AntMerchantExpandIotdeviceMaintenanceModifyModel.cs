using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandIotdeviceMaintenanceModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandIotdeviceMaintenanceModifyModel : AopObject
    {
        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("gmt_created")]
        public string GmtCreated { get; set; }

        /// <summary>
        /// 订单修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 安装入驻订单号
        /// </summary>
        [XmlElement("install_order_id")]
        public string InstallOrderId { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 新设备SN
        /// </summary>
        [XmlElement("new_device_sn")]
        public string NewDeviceSn { get; set; }

        /// <summary>
        /// 旧设备SN，被替换的设备
        /// </summary>
        [XmlElement("old_device_sn")]
        public string OldDeviceSn { get; set; }

        /// <summary>
        /// 维保订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 问题类型
        /// </summary>
        [XmlElement("problem_type")]
        public string ProblemType { get; set; }

        /// <summary>
        /// 报修人电话
        /// </summary>
        [XmlElement("repair_mobile")]
        public string RepairMobile { get; set; }

        /// <summary>
        /// 报修人姓名
        /// </summary>
        [XmlElement("repair_name")]
        public string RepairName { get; set; }

        /// <summary>
        /// 店铺联系人电话 说明：只做维保记录使用，不会变更设备对应的【店铺联系人电话】信息，如果设备信息变更需要使用变更接口服务
        /// </summary>
        [XmlElement("shop_contact_mobile")]
        public string ShopContactMobile { get; set; }

        /// <summary>
        /// 店铺联系人姓名 说明：只做维保记录信息使用，不会变更设备对应的【店铺联系人】信息，如果设备信息变更需要使用变更接口服务
        /// </summary>
        [XmlElement("shop_contact_name")]
        public string ShopContactName { get; set; }

        /// <summary>
        /// 店铺名称 说明：只做维保记录使用，不会变更设备对应的【店铺名称】信息，如果设备信息变更需要使用变更接口服务
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 签约支付宝PID（有效）(必须与原始设备签约账号一致)
        /// </summary>
        [XmlElement("signed_alipay_id")]
        public string SignedAlipayId { get; set; }

        /// <summary>
        /// 供应商id
        /// </summary>
        [XmlElement("supplier_sn")]
        public string SupplierSn { get; set; }
    }
}
