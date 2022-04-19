using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpCreditlinkCollectQueryResponse.
    /// </summary>
    public class ZhimaCreditEpCreditlinkCollectQueryResponse : AopResponse
    {
        /// <summary>
        /// INIT表示任务还在初始化状态，COLLECT表示任务在进行中，END状态表示任务处理完成。
        /// </summary>
        [XmlElement("data_status")]
        public string DataStatus { get; set; }

        /// <summary>
        /// 请求数据类型。与传入值一致
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 数据内容加密方式。通过改加密方式和随机密钥信封可解密数据内容
        /// </summary>
        [XmlElement("encrypt_model")]
        public string EncryptModel { get; set; }

        /// <summary>
        /// 文件地址列表。 文件内容为加密内容，需要使用上面的secret进行解密。具体内容格式与data_type有关。 文件地址有一定有效期，请及时取回
        /// </summary>
        [XmlArray("file_list")]
        [XmlArrayItem("string")]
        public List<string> FileList { get; set; }

        /// <summary>
        /// 返回的数据文件数量
        /// </summary>
        [XmlElement("file_num")]
        public long FileNum { get; set; }

        /// <summary>
        /// 数据返回结果，包含数据类型和对应的访问地址
        /// </summary>
        [XmlArray("files")]
        [XmlArrayItem("data_file")]
        public List<DataFile> Files { get; set; }

        /// <summary>
        /// 商户单号。与传入值一致
        /// </summary>
        [XmlElement("merchant_request_id")]
        public string MerchantRequestId { get; set; }

        /// <summary>
        /// 随机秘钥信封。可使用该密钥解密数据内容
        /// </summary>
        [XmlElement("secret")]
        public string Secret { get; set; }
    }
}
