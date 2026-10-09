using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// SsdataDataserviceDtevalIdentitycheckQueryResponse.
    /// </summary>
    public class SsdataDataserviceDtevalIdentitycheckQueryResponse : AopResponse
    {
        /// <summary>
        /// evidence：关联人的手机号是否和该用户通话以及通话次数
        /// </summary>
        [XmlElement("evidence")]
        public string Evidence { get; set; }

        /// <summary>
        /// ext_map:额外参数，预留
        /// </summary>
        [XmlElement("ext_map")]
        public string ExtMap { get; set; }

        /// <summary>
        /// id_card_no_match_flag:身份证号匹配结果标识，表示传入的身份证号是否匹配，含四种状态：完全匹配成功（MATCHSUCCESS），模糊匹配成功（FUZZYMATCHSUCCESS），匹配失败（MATCHFAIL），无数据（NODATA）
        /// </summary>
        [XmlElement("id_card_no_match_flag")]
        public string IdCardNoMatchFlag { get; set; }

        /// <summary>
        /// name_match_flag:姓名匹配标识，表示传入的姓名是否匹配，含四种状态：完全匹配成功（MATCHSUCCESS），模糊匹配成功（FUZZYMATCHSUCCESS），匹配失败（MATCHFAIL），无数据（NODATA）
        /// </summary>
        [XmlElement("name_match_flag")]
        public string NameMatchFlag { get; set; }

        /// <summary>
        /// push_ant_data_flag:是否推送蚂蚁数据标志,推送成功返回true，失败返回false
        /// </summary>
        [XmlElement("push_ant_data_flag")]
        public string PushAntDataFlag { get; set; }
    }
}
