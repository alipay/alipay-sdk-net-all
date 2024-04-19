using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossProdAntlegalchainNdasignerCreateResponse.
    /// </summary>
    public class AlipayBossProdAntlegalchainNdasignerCreateResponse : AopResponse
    {
        /// <summary>
        /// 失败的记录集合,只记录创建失败或通知失败的记录
        /// </summary>
        [XmlArray("import_signer_info_list")]
        [XmlArrayItem("import_signer_info")]
        public List<ImportSignerInfo> ImportSignerInfoList { get; set; }
    }
}
