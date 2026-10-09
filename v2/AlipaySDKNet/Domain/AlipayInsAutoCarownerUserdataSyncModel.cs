using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsAutoCarownerUserdataSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsAutoCarownerUserdataSyncModel : AopObject
    {
        /// <summary>
        /// 发动机号
        /// </summary>
        [XmlElement("car_engine_no")]
        public string CarEngineNo { get; set; }

        /// <summary>
        /// 车架号
        /// </summary>
        [XmlElement("car_frame_no")]
        public string CarFrameNo { get; set; }

        /// <summary>
        /// 车辆品牌型号
        /// </summary>
        [XmlElement("car_model")]
        public string CarModel { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("car_no")]
        public string CarNo { get; set; }

        /// <summary>
        /// md5加密后的证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 保险公司标识
        /// </summary>
        [XmlElement("com_id")]
        public string ComId { get; set; }

        /// <summary>
        /// 注册日期
        /// </summary>
        [XmlElement("first_register_date")]
        public string FirstRegisterDate { get; set; }

        /// <summary>
        /// 外部名单id
        /// </summary>
        [XmlElement("out_leads_id")]
        public string OutLeadsId { get; set; }

        /// <summary>
        /// 数据发送时间
        /// </summary>
        [XmlElement("send_time")]
        public string SendTime { get; set; }
    }
}
