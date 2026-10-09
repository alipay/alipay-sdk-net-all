using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IsvMerchantSalesDetailRequest Data Structure.
    /// </summary>
    [Serializable]
    public class IsvMerchantSalesDetailRequest : AopObject
    {
        /// <summary>
        /// 配券数
        /// </summary>
        [XmlElement("coupons_quantity")]
        public string CouponsQuantity { get; set; }

        /// <summary>
        /// 设备详情
        /// </summary>
        [XmlElement("device_detail")]
        public string DeviceDetail { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 小程序appid，若推广的商品不为小程序，则不传此参数
        /// </summary>
        [XmlElement("mini_appid")]
        public string MiniAppid { get; set; }

        /// <summary>
        /// 作业地
        /// </summary>
        [XmlElement("operation_place")]
        public string OperationPlace { get; set; }

        /// <summary>
        /// 外部业务号，传isv系统生成的账单号，需要保证唯一
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 推广服务商(S2)pid
        /// </summary>
        [XmlElement("promotor_pid")]
        public string PromotorPid { get; set; }

        /// <summary>
        /// 销售金额，这里填写的是整数，单位为分，比如1元，那么输入100
        /// </summary>
        [XmlElement("sales_amount")]
        public string SalesAmount { get; set; }

        /// <summary>
        /// 销售笔数
        /// </summary>
        [XmlElement("sales_quantity")]
        public string SalesQuantity { get; set; }

        /// <summary>
        /// 推广服务商(S2)子账号pid
        /// </summary>
        [XmlElement("sub_promotor_pid")]
        public string SubPromotorPid { get; set; }

        /// <summary>
        /// 核销金额，这里填写的是整数，单位为分，比如1元，那么输入100
        /// </summary>
        [XmlElement("write_off_amount")]
        public string WriteOffAmount { get; set; }

        /// <summary>
        /// 核销数
        /// </summary>
        [XmlElement("write_off_quantity")]
        public string WriteOffQuantity { get; set; }
    }
}
