using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbasePassportinfoBatchqueryResponse.
    /// </summary>
    public class AnttechOceanbasePassportinfoBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 注册账号信息列表
        /// </summary>
        [XmlArray("passport_infos")]
        [XmlArrayItem("passport_info_d_t_o")]
        public List<PassportInfoDTO> PassportInfos { get; set; }
    }
}
