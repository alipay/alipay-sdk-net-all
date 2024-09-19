using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// XingheLendassistCarfinInstinfoNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class XingheLendassistCarfinInstinfoNotifyModel : AopObject
    {
        /// <summary>
        /// 星河侧唯一业务编号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 车辆信息，详情见下面CarInfo参数
        /// </summary>
        [XmlElement("car_info")]
        public CarInfo CarInfo { get; set; }

        /// <summary>
        /// 文件列表
        /// </summary>
        [XmlArray("file_list")]
        [XmlArrayItem("file_detail")]
        public List<FileDetail> FileList { get; set; }

        /// <summary>
        /// 机构侧唯一业务编号
        /// </summary>
        [XmlElement("out_apply_no")]
        public string OutApplyNo { get; set; }

        /// <summary>
        /// 传输信息列表，指定回传信息
        /// </summary>
        [XmlArray("postback_list")]
        [XmlArrayItem("string")]
        public List<string> PostbackList { get; set; }

        /// <summary>
        /// 车辆估值信息，详情见下面ValuationInfo参数
        /// </summary>
        [XmlElement("valuation_info")]
        public ValuationInfo ValuationInfo { get; set; }
    }
}
