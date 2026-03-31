using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdAltechlegalDepositCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdAltechlegalDepositCreateModel : AopObject
    {
        /// <summary>
        /// 文件类型标识
        /// </summary>
        [XmlElement("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 企业的社会信用代码
        /// </summary>
        [XmlElement("corp_code")]
        public string CorpCode { get; set; }

        /// <summary>
        /// 存证动作名称
        /// </summary>
        [XmlElement("deposit_name")]
        public string DepositName { get; set; }

        /// <summary>
        /// 发起存证的设备信息
        /// </summary>
        [XmlElement("device_info")]
        public string DeviceInfo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("file_list")]
        [XmlArrayItem("file_list")]
        public List<FileList> FileList { get; set; }

        /// <summary>
        /// 取证的地址
        /// </summary>
        [XmlElement("record_address")]
        public string RecordAddress { get; set; }

        /// <summary>
        /// 来源系统标识，需要与技术对齐，不可随意修改
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
