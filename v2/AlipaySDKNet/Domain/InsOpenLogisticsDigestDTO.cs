using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsOpenLogisticsDigestDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsOpenLogisticsDigestDTO : AopObject
    {
        /// <summary>
        /// 认证码
        /// </summary>
        [XmlElement("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 认证码类型 1. NONE (不需要验证码) 2. QR_CODE (二维码) 3. NUMBER (数字码) 4. CANCEL_NUMBER (取消数字码)
        /// </summary>
        [XmlElement("auth_type")]
        public string AuthType { get; set; }

        /// <summary>
        /// 物流公司编码
        /// </summary>
        [XmlElement("logistics_company_code")]
        public string LogisticsCompanyCode { get; set; }

        /// <summary>
        /// 物流商名称
        /// </summary>
        [XmlElement("logistics_company_name")]
        public string LogisticsCompanyName { get; set; }

        /// <summary>
        /// 物流商快递单号
        /// </summary>
        [XmlElement("logistics_no")]
        public string LogisticsNo { get; set; }

        /// <summary>
        /// 物流状态:0:已下单;1:已揽收;5:入库;2:已签收;8:已投柜;9:待取件;
        /// </summary>
        [XmlElement("logistics_status")]
        public long LogisticsStatus { get; set; }

        /// <summary>
        /// 预约取件截止时间
        /// </summary>
        [XmlElement("reserve_end_time")]
        public string ReserveEndTime { get; set; }

        /// <summary>
        /// 用户预约取件起始时间
        /// </summary>
        [XmlElement("reserve_start_time")]
        public string ReserveStartTime { get; set; }
    }
}
