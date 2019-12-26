using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataIotdataSearchlibraryBaiUploadResponse.
    /// </summary>
    public class AlipayDataIotdataSearchlibraryBaiUploadResponse : AopResponse
    {
        /// <summary>
        /// 更新失败原因
        /// </summary>
        [XmlElement("update_desc")]
        public string UpdateDesc { get; set; }

        /// <summary>
        /// 更新是否成功
        /// </summary>
        [XmlElement("update_result")]
        public bool UpdateResult { get; set; }
    }
}
