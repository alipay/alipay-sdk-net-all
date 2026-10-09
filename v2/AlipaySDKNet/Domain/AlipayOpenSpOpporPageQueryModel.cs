using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpOpporPageQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpOpporPageQueryModel : AopObject
    {
        /// <summary>
        /// 服务商pid
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 页数
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 作业记录状态列表,以,拼接传入
        /// </summary>
        [XmlElement("status_list")]
        public string StatusList { get; set; }
    }
}
