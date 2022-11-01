using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BkAgentReqInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BkAgentReqInfo : AopObject
    {
        /// <summary>
        /// 收单机构在清算组织登记或分配的机构代码
        /// </summary>
        [XmlElement("acq_code")]
        public string AcqCode { get; set; }

        /// <summary>
        /// 终端设备类型，受理方可参考终端 注册时的设备类型填写，取值如下: 01:自动柜员机(含 ATM 和 CDM) 和多媒体自助终端  02:传统 POS 03:mPOS 04:智能 POS 05:II 型固定电话 06:云闪付终端; 07:保留使用; 08:手机 POS; 09:刷脸付终端; 10:条码支付受理终端; 11:条码支付辅助受理终端; 12:行业终端(公交、地铁用于指 定行业的终端); 13:MIS 终端;
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 终端设备实时经纬度信息，格式为纬度/经度，+表示北纬、东经，-表示南纬、西经。
        /// </summary>
        [XmlElement("location")]
        public string Location { get; set; }

        /// <summary>
        /// 收单机构在清算组织登记的商户编码
        /// </summary>
        [XmlElement("merch_code")]
        public string MerchCode { get; set; }

        /// <summary>
        /// 终端类型填写为 02、 03、04、05、06、08、09 或 10 时，必 须填写终端序列号。
        /// </summary>
        [XmlElement("serial_num")]
        public string SerialNum { get; set; }
    }
}
