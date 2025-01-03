using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechAiDonationServiceCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechAiDonationServiceCreateModel : AopObject
    {
        /// <summary>
        /// 业务回执字段，服务不做处理，透传回给调用方做相关业务逻辑处理。
        /// </summary>
        [XmlElement("biz_receipt")]
        public string BizReceipt { get; set; }

        /// <summary>
        /// 用户输入：的祝福内容，最大不超过128位，需要做内容安全检测
        /// </summary>
        [XmlElement("bless_content")]
        public string BlessContent { get; set; }

        /// <summary>
        /// 一体机设备的ID，全局唯一
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 捐献金额，单位是元，保留两位小数
        /// </summary>
        [XmlElement("donation_amount")]
        public string DonationAmount { get; set; }

        /// <summary>
        /// 捐献成功的支付日期
        /// </summary>
        [XmlElement("donation_date")]
        public string DonationDate { get; set; }

        /// <summary>
        /// 捐献数量，用来显示在首页轮播列表的角标值
        /// </summary>
        [XmlElement("donation_number")]
        public long DonationNumber { get; set; }

        /// <summary>
        /// 捐献类型 DONATION 捐献;TILE_DONATION 捐瓦
        /// </summary>
        [XmlElement("donation_type")]
        public string DonationType { get; set; }

        /// <summary>
        /// 用户输入：捐赠者的姓名，最大不超过128位，需要做内容安全检测
        /// </summary>
        [XmlElement("donor_name")]
        public string DonorName { get; set; }

        /// <summary>
        /// 外部客户ID，客户的唯一标识
        /// </summary>
        [XmlElement("external_client_id")]
        public string ExternalClientId { get; set; }

        /// <summary>
        /// 调用方传入数据的唯一请求Id,用来幂等处理
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 终端一体机显示标识：true 表示会在终端一体机上显示礼成和首页轮播效果，false则表示不会在终端一体机上显示任何效果
        /// </summary>
        [XmlElement("terminal_display")]
        public bool TerminalDisplay { get; set; }
    }
}
