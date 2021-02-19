using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppCommunityPubkeyQueryResponse.
    /// </summary>
    public class AlipayEbppCommunityPubkeyQueryResponse : AopResponse
    {
        /// <summary>
        /// 公钥json的md5值，若与上次相同则无需更新到机具
        /// </summary>
        [XmlElement("e_tag")]
        public string ETag { get; set; }

        /// <summary>
        /// 公钥列表，isv无需理解内容，需转化成json字符串保存进机具。 可自定义机具中的文件路径，默认使用和sdk的同级目录的文件，文件名为pubkey.txt
        /// </summary>
        [XmlArray("pubkey_list")]
        [XmlArrayItem("access_public_key")]
        public List<AccessPublicKey> PubkeyList { get; set; }
    }
}
