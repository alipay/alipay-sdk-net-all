using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserCertifyRarenameUniandpuaTransferResponse.
    /// </summary>
    public class AlipayUserCertifyRarenameUniandpuaTransferResponse : AopResponse
    {
        /// <summary>
        /// 多于一字两码时，返回其他的编码。返回不包括ret_name和入参中的姓名。
        /// </summary>
        [XmlArray("other_names")]
        [XmlArrayItem("rare_name_encode_info")]
        public List<RareNameEncodeInfo> OtherNames { get; set; }

        /// <summary>
        /// 转码后的姓名
        /// </summary>
        [XmlElement("ret_name")]
        public string RetName { get; set; }
    }
}
