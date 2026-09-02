using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LeadsImportItem Data Structure.
    /// </summary>
    [Serializable]
    public class LeadsImportItem : AopObject
    {
        /// <summary>
        /// 司机主要营运出租业务的城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 司机所属出租车公司 如果不填则默认为个体工商户
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 司机身份证号
        /// </summary>
        [XmlElement("driver_cert_no")]
        public string DriverCertNo { get; set; }

        /// <summary>
        /// 司机名称
        /// </summary>
        [XmlElement("driver_name")]
        public string DriverName { get; set; }

        /// <summary>
        /// 司机运营出租车牌照号码 可不填
        /// </summary>
        [XmlElement("driver_plate")]
        public string DriverPlate { get; set; }

        /// <summary>
        /// 在税务局登记的税号 可以是个人税号或者所属公司的税号
        /// </summary>
        [XmlElement("driver_tax_no")]
        public string DriverTaxNo { get; set; }

        /// <summary>
        /// 联系电话号码
        /// </summary>
        [XmlElement("phone_one")]
        public string PhoneOne { get; set; }

        /// <summary>
        /// 备用手机号
        /// </summary>
        [XmlElement("phone_three")]
        public string PhoneThree { get; set; }

        /// <summary>
        /// 备用手机号
        /// </summary>
        [XmlElement("phone_two")]
        public string PhoneTwo { get; set; }

        /// <summary>
        /// 录入人对本司机的备注信息
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 标识自己的数据来源 数值找支付宝端申请分配
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
