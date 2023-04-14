using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Org.BouncyCastle.X509;
using Aop.Api.Util.Asymmetric;

namespace Aop.Api.Util
{
    /// <summary>
    /// 支付宝签名工具类
    /// </summary>
    public static class AlipaySignature
    {
        /** 默认编码字符集 */
        private static readonly string DEFAULT_CHARSET = "GBK";

        /// <summary>
        /// 从支付宝公钥证书中提取支付宝公钥
        /// </summary>
        /// <param name="certPath">证书路径</param>
        /// <returns>公钥字符串</returns>
        public static string ExtractPemPublicKeyFromCert(string certPath)
        {
            ArgumentValidator.CheckArgument(!String.IsNullOrEmpty(certPath), "证书文件路径不可为空。");

            X509Certificate alipayPublicKeyCert = AntCertificationUtil.ParseCert(File.ReadAllText(certPath));
            return AntCertificationUtil.ExtractPemPublicKeyFromCert(alipayPublicKeyCert);
        }

        /// <summary>
        /// 异步通知参数验签，支持RSA、RSA2、SM2三种算法
        /// V1版本方法将删除sign_type参数再进行验签，V2版本方法则不会
        /// </summary>
        /// <param name="parameters">待验签的参数集合</param>
        /// <param name="alipayPublicCertPath">支付宝公钥证书路径</param>
        /// <param name="charset">参数编码字符集</param>
        /// <param name="signType">签名类型，RSA2或RSA、SM2</param>
        /// <returns>true：验证成功；false：验证失败</returns>
        public static bool CertVerifyV1(IDictionary<string, string> parameters, string alipayPublicCertPath, string charset, string signType)
        {
            return RSACertCheckV1(parameters, alipayPublicCertPath, charset, signType);
        }

        /// <summary>
        /// 异步通知参数验签，支持RSA、RSA2、SM2三种算法，推荐替换为相同功能的方法CertVerifyV1
        /// V1版本方法将删除sign_type参数再进行验签，V2版本方法则不会
        /// </summary>
        /// <param name="parameters">待验签的参数集合</param>
        /// <param name="alipayPublicCertPath">支付宝公钥证书路径</param>
        /// <param name="charset">参数编码字符集</param>
        /// <param name="signType">签名类型，RSA2或RSA、SM2</param>
        /// <returns>true：验证成功；false：验证失败</returns>
        public static bool RSACertCheckV1(IDictionary<string, string> parameters, string alipayPublicCertPath, string charset, string signType)
        {
            ArgumentValidator.CheckNotNull(parameters, "parameters参数不可为Null");
            ArgumentValidator.CheckArgument(!String.IsNullOrEmpty(alipayPublicCertPath), "证书文件路径不可为空。");

            string alipayPublicKey = ExtractPemPublicKeyFromCert(alipayPublicCertPath);
            return RSACheckV1(parameters, alipayPublicKey, charset, signType, false);
        }

        /// <summary>
        /// 异步通知参数验签，支持RSA、RSA2、SM2三种算法
        /// V1版本方法将删除sign_type参数再进行验签，V2版本方法则不会
        /// </summary>
        /// <param name="parameters">待验签字符串</param>
        /// <param name="publicKey">支付宝公钥</param>
        /// <param name="charset">参数编码字符集</param>
        /// <param name="signType">签名类型，RSA2或RSA、SM2</param>
        /// <param name="keyFromFile">是否从文件加载支付宝公钥内容。
        /// 如果该参数为true，则publicKey为公钥文件路径；
        /// 如果该参数为false，则publicKey为公钥内容
        /// </param>
        /// <returns>true：验证成功；false：验证失败</returns>
        public static bool VerifyV1(IDictionary<string, string> parameters, string publicKey, string charset, string signType, bool keyFromFile)
        {
            return RSACheckV1(parameters, publicKey, charset, signType, keyFromFile);
        }

        /// <summary>
        /// 异步通知参数验签，支持RSA、RSA2、SM2三种算法，推荐替换为相同功能的方法VerifyV1
        /// V1版本方法将删除sign_type参数再进行验签，V2版本方法则不会
        /// </summary>
        /// <param name="parameters">待验签字符串</param>
        /// <param name="publicKey">支付宝公钥</param>
        /// <param name="charset">参数编码字符集</param>
        /// <param name="signType">签名类型，RSA2或RSA、SM2</param>
        /// <param name="keyFromFile">是否从文件加载支付宝公钥内容。
        /// 如果该参数为true，则publicKey为公钥文件路径；
        /// 如果该参数为false，则publicKey为公钥内容
        /// </param>
        /// <returns>true：验证成功；false：验证失败</returns>
        public static bool RSACheckV1(IDictionary<string, string> parameters, string publicKey, string charset, string signType, bool keyFromFile)
        {
            ArgumentValidator.CheckNotNull(parameters, "parameters参数不可为Null");

            string sign = parameters["sign"];
            parameters.Remove("sign");
            parameters.Remove("sign_type");
            string signContent = GetSignContent(parameters);
            return RSACheckContent(signContent, sign, publicKey, charset, signType, keyFromFile);
        }

        /// <summary>
        /// 异步通知参数验签，支持RSA、RSA2、SM2三种算法
        /// V1版本方法将删除sign_type参数再进行验签，V2版本方法则不会
        /// </summary>
        /// <param name="parameters">待验签的参数集合</param>
        /// <param name="alipayPublicCertPath">支付宝公钥证书路径</param>
        /// <param name="charset">参数编码字符集</param>
        /// <param name="signType">签名类型，RSA2或RSA、SM2</param>
        /// <returns>true：验证成功；false：验证失败</returns>
        public static bool CertVerifyV2(IDictionary<string, string> parameters, string alipayPublicCertPath, string charset, string signType)
        {
            return RSACertCheckV2(parameters, alipayPublicCertPath, charset, signType);
        }

        /// <summary>
        /// 异步通知参数验签，支持RSA、RSA2、SM2三种算法，推荐替换为相同功能的方法CertVerifyV2
        /// V1版本方法将删除sign_type参数再进行验签，V2版本方法则不会
        /// </summary>
        /// <param name="parameters">待验签的参数集合</param>
        /// <param name="alipayPublicCertPath">支付宝公钥证书路径</param>
        /// <param name="charset">参数编码字符集</param>
        /// <param name="signType">签名类型，RSA2或RSA、SM2</param>
        /// <returns>true：验证成功；false：验证失败</returns>
        public static bool RSACertCheckV2(IDictionary<string, string> parameters, string alipayPublicCertPath, string charset, string signType)
        {
            ArgumentValidator.CheckNotNull(parameters, "parameters参数不可为Null");

            string alipayPublicKey = ExtractPemPublicKeyFromCert(alipayPublicCertPath);
            return RSACheckV2(parameters, alipayPublicKey, charset, signType, false);
        }

        /// <summary>
        /// 异步通知参数验签，支持RSA、RSA2、SM2三种算法
        /// V1版本方法将删除sign_type参数再进行验签，V2版本方法则不会
        /// </summary>
        /// <param name="parameters">待验签字符串</param>
        /// <param name="publicKey">支付宝公钥</param>
        /// <param name="charset">参数编码字符集</param>
        /// <param name="signType">签名类型，RSA2或RSA、SM2</param>
        /// <param name="keyFromFile">是否从文件加载支付宝公钥内容。
        /// 如果该参数为true，则publicKey为公钥文件路径；
        /// 如果该参数为false，则publicKey为公钥内容
        /// </param>
        /// <returns>true：验证成功；false：验证失败</returns>
        public static bool VerifyV2(IDictionary<string, string> parameters, string publicKey, string charset, string signType, bool keyFromFile)
        {
            return RSACheckV2(parameters, publicKey, charset, signType, keyFromFile);
        }

        /// <summary>
        /// 异步通知参数验签，支持RSA、RSA2、SM2三种算法，推荐替换为相同功能的方法VerifyV2
        /// V1版本方法将删除sign_type参数再进行验签，V2版本方法则不会
        /// </summary>
        /// <param name="parameters">待验签字符串</param>
        /// <param name="publicKey">支付宝公钥</param>
        /// <param name="charset">参数编码字符集</param>
        /// <param name="signType">签名类型，RSA2或RSA、SM2</param>
        /// <param name="keyFromFile">是否从文件加载支付宝公钥内容。
        /// 如果该参数为true，则publicKey为公钥文件路径；
        /// 如果该参数为false，则publicKey为公钥内容
        /// </param>
        /// <returns>true：验证成功；false：验证失败</returns>
        public static bool RSACheckV2(IDictionary<string, string> parameters, string publicKey, string charset, string signType, bool keyFromFile)
        {
            ArgumentValidator.CheckNotNull(parameters, "parameters参数不可为Null");

            string sign = parameters["sign"];
            parameters.Remove("sign");
            string signContent = GetSignContent(parameters);
            return RSACheckContent(signContent, sign, publicKey, charset, signType, keyFromFile);
        }

        /// <summary>
        /// 验证指定内容的签名，支持RSA、RSA2、SM2三种算法
        /// </summary>
        /// <param name="content">待验签的内容</param>
        /// <param name="sign">签名字符串</param>
        /// <param name="publicKey">支付宝公钥</param>
        /// <param name="charset">字符集编码</param>
        /// <param name="signType">签名算法类型，RSA2或RSA、SM2</param>
        /// <param name="keyFromFile">是否从文件加载支付宝公钥内容。
        /// 如果该参数为true，则publicKey为公钥文件路径；
        /// 如果该参数为false，则publicKey为公钥内容
        /// </param>
        /// <returns>true：验证成功；false：验证失败</returns>
        public static bool VerifyContent(string content, string sign, string publicKey, string charset, string signType, bool keyFromFile)
        {
            return RSACheckContent(content, sign, publicKey, charset, signType, keyFromFile);
        }

        /// <summary>
        /// 验证指定内容的签名，支持RSA、RSA2、SM2三种算法，推荐替换为相同功能的方法VerifyContent
        /// </summary>
        /// <param name="content">待验签的内容</param>
        /// <param name="sign">签名字符串</param>
        /// <param name="publicKey">支付宝公钥</param>
        /// <param name="charset">字符集编码</param>
        /// <param name="signType">签名算法类型，RSA2或RSA、SM2</param>
        /// <param name="keyFromFile">是否从文件加载支付宝公钥内容。
        /// 如果该参数为true，则publicKey为公钥文件路径；
        /// 如果该参数为false，则publicKey为公钥内容
        /// </param>
        /// <returns>true：验证成功；false：验证失败</returns>
        public static bool RSACheckContent(string content, string sign, string publicKey, string charset, string signType, bool keyFromFile)
        {
            if (keyFromFile)
            {
                ArgumentValidator.CheckArgument(!String.IsNullOrEmpty(publicKey), "公钥文件路径不可为空。");
                publicKey = File.ReadAllText(publicKey);
            }

            return AsymmetricManager.GetByName(signType).Verify(content, charset, publicKey, sign);
        }

        /// <summary>
        /// 对指定参数进行签名，支持RSA、RSA2、SM2三种算法
        /// </summary>
        /// <param name="parameters">参数集合</param>
        /// <param name="privateKey">商户私钥</param>
        /// <param name="charset">字符集编码</param>
        /// <param name="signType">签名算法类型，RSA2或RSA、SM2</param>
        /// <param name="keyFromFile">是否从私钥证书文件中加载私钥
        /// 如果该参数为true，privateKey为私钥证书文件路径；
        /// 如果该参数为false，privateKey为私钥内容字符串
        /// </param>
        /// <returns>签名字符串</returns>
        public static string Sign(IDictionary<string, string> parameters, string privateKey, string charset, string signType, bool keyFromFile)
        {
            return RSASign(parameters, privateKey, charset, signType, keyFromFile);
        }

        /// <summary>
        /// 对指定参数进行签名，支持RSA、RSA2、SM2三种算法，推荐替换为相同功能的方法Sign
        /// </summary>
        /// <param name="parameters">参数集合</param>
        /// <param name="privateKey">商户私钥</param>
        /// <param name="charset">字符集编码</param>
        /// <param name="signType">签名算法类型，RSA2或RSA、SM2</param>
        /// <param name="keyFromFile">是否从私钥证书文件中加载私钥
        /// 如果该参数为true，privateKey为私钥证书文件路径；
        /// 如果该参数为false，privateKey为私钥内容字符串
        /// </param>
        /// <returns>签名字符串</returns>
        public static string RSASign(IDictionary<string, string> parameters, string privateKey, string charset, string signType, bool keyFromFile)
        {
            ArgumentValidator.CheckNotNull(parameters, "parameters参数不可为Null");

            string signContent = GetSignContent(parameters);
            return RSASignCharSet(signContent, privateKey, charset, signType, keyFromFile);
        }

        /// <summary>
        /// 对指定内容进行签名，支持RSA、RSA2、SM2三种算法
        /// </summary>
        /// <param name="data">内容字符串</param>
        /// <param name="privateKey">商户私钥</param>
        /// <param name="charset">字符集编码</param>
        /// <param name="signType">签名算法类型，RSA2或RSA、SM2</param>
        /// <param name="keyFromFile">是否从私钥证书文件中加载私钥
        /// 如果该参数为true，privateKey为私钥证书文件路径；
        /// 如果该参数为false，privateKey为私钥内容字符串
        /// </param>
        /// <returns>签名字符串</returns>
        public static string Sign(string data, string privateKey, string charset, string signType, bool keyFromFile)
        {
            return RSASign(data, privateKey, charset, signType, keyFromFile);
        }

        /// <summary>
        /// 对指定内容进行签名，支持RSA、RSA2、SM2三种算法，推荐替换为相同功能的方法Sign
        /// </summary>
        /// <param name="data">内容字符串</param>
        /// <param name="privateKey">商户私钥</param>
        /// <param name="charset">字符集编码</param>
        /// <param name="signType">签名算法类型，RSA2或RSA、SM2</param>
        /// <param name="keyFromFile">是否从私钥证书文件中加载私钥
        /// 如果该参数为true，privateKey为私钥证书文件路径；
        /// 如果该参数为false，privateKey为私钥内容字符串
        /// </param>
        /// <returns>签名字符串</returns>
        public static string RSASign(string data, string privateKey, string charset, string signType, bool keyFromFile)
        {
            return RSASignCharSet(data, privateKey, charset, signType, keyFromFile);
        }

        /// <summary>
        /// 验签并解密，目前仅适用于生活号
        /// </summary>
        /// <param name="parameters">待验签并解密的参数</param>
        /// <param name="alipayPublicKey">支付宝公钥字符串，用于验签</param>
        /// <param name="cusPrivateKey">商户私钥字符串，用于解密</param>
        /// <param name="isCheckSign">是否检查签名</param>
        /// <param name="isDecrypt">是否解密</param>
        /// <param name="signType">非对称加密算法类型，RSA2或RSA、SM2</param>
        /// <param name="keyFromFile">是否从文件加载支付宝公钥和商户私钥
        /// 如果该参数为true，alipayPublicKey为公钥文件路径，cusPrivateKey为私钥证书文件路径；
        /// 如果该参数为false，则publicKeyPem为公钥内容字符串，cusPrivateKey为私钥内容字符串
        /// </param>
        /// <returns>验签解密后的内容</returns>
        public static string CheckSignAndDecrypt(IDictionary<string, string> parameters, string alipayPublicKey, string cusPrivateKey,
            bool isCheckSign, bool isDecrypt, string signType, bool keyFromFile)
        {
            ArgumentValidator.CheckNotNull(parameters, "parameters参数不可为Null");

            string charset = parameters["charset"];
            string bizContent = parameters["biz_content"];
            if (isCheckSign)
            {
                if (!RSACheckV2(parameters, alipayPublicKey, charset, signType, keyFromFile))
                {
                    throw new AopException("rsaCheck failure:rsaParams=" + parameters);
                }
            }

            if (isDecrypt)
            {
                return RSADecrypt(bizContent, cusPrivateKey, charset, signType, keyFromFile);
            }

            return bizContent;
        }

        /// <summary>
        /// 加密并加签，目前仅适用于生活号
        /// </summary>
        /// <param name="bizContent">待加密和加签的原文</param>
        /// <param name="alipayPublicKey">支付宝公钥字符串，用于加密</param>
        /// <param name="cusPrivateKey">商户私钥字符串，用于加签</param>
        /// <param name="charset">字符集编码</param>
        /// <param name="isEncrypt">是否需要加密</param>
        /// <param name="isSign">是否需要加签</param>
        /// <param name="signType">非对称加密算法类型，RSA或RSA2、SM2</param>
        /// <param name="keyFromFile">是否从文件加载支付宝公钥和商户私钥
        /// 如果该参数为true，alipayPublicKey为公钥文件路径，cusPrivateKey为私钥证书文件路径；
        /// 如果该参数为false，则publicKeyPem为公钥内容字符串，cusPrivateKey为私钥内容字符串
        /// </param>
        /// <returns>加密加签后的内容</returns>
        public static string EncryptAndSign(string bizContent, string alipayPublicKey, string cusPrivateKey, string charset,
            bool isEncrypt, bool isSign, string signType, bool keyFromFile)
        {
            StringBuilder sb = new StringBuilder();
            if (string.IsNullOrEmpty(charset))
            {
                charset = DEFAULT_CHARSET;
            }
            sb.Append("<?xml version=\"1.0\" encoding=\"" + charset + "\"?>");
            if (isEncrypt)
            {
                // 加密
                sb.Append("<alipay>");
                String encrypted = RSAEncrypt(bizContent, alipayPublicKey, charset, keyFromFile);
                sb.Append("<response>" + encrypted + "</response>");
                sb.Append("<encryption_type>" + signType + "</encryption_type>");
                if (isSign)
                {
                    String sign = RSASign(encrypted, cusPrivateKey, charset, signType, keyFromFile);
                    sb.Append("<sign>" + sign + "</sign>");
                    sb.Append("<sign_type>" + signType + "</sign_type>");
                }
                sb.Append("</alipay>");
            }
            else if (isSign)
            {
                // 不加密，但需要签名
                sb.Append("<alipay>");
                sb.Append("<response>" + bizContent + "</response>");
                String sign = RSASign(bizContent, cusPrivateKey, charset, signType, keyFromFile);
                sb.Append("<sign>" + sign + "</sign>");
                sb.Append("<sign_type>" + signType + "</sign_type>");
                sb.Append("</alipay>");
            }
            else
            {
                // 不加密，不加签
                sb.Append(bizContent);
            }
            return sb.ToString();
        }





        public static string GetSignContent(IDictionary<string, string> parameters)
        {
            // 第一步：把字典按Key的字母顺序排序
            IDictionary<string, string> sortedParams = new SortedDictionary<string, string>(parameters, StringComparer.Ordinal);
            IEnumerator<KeyValuePair<string, string>> dem = sortedParams.GetEnumerator();

            // 第二步：把所有参数名和参数值串在一起
            StringBuilder query = new StringBuilder("");
            while (dem.MoveNext())
            {
                string key = dem.Current.Key;
                string value = dem.Current.Value;
                if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
                {
                    query.Append(key).Append("=").Append(value).Append("&");
                }
            }
            string content = query.ToString().Substring(0, query.Length - 1);

            return content;
        }

        public static string RSASignCharSet(string data, string privateKeyPem, string charset, string signType, bool keyFromFile)
        {
            if (keyFromFile)
            {
                ArgumentValidator.CheckArgument(!String.IsNullOrEmpty(privateKeyPem), "私钥文件路径不可为空。");
                privateKeyPem = LoadPrivateKeyFromRSACertFile(privateKeyPem);
            }

            return AsymmetricManager.GetByName(signType).Sign(data, charset, privateKeyPem);
        }

        public static string RSAEncrypt(string content, string publicKeyPem, string charset, bool keyFromFile)
        {
            if (keyFromFile)
            {
                ArgumentValidator.CheckArgument(!String.IsNullOrEmpty(publicKeyPem), "公钥文件路径不可为空。");
                publicKeyPem = File.ReadAllText(publicKeyPem);
            }

            return AsymmetricManager.GetByName("RSA").Encrypt(content, charset, publicKeyPem);
        }

        public static string RSADecrypt(string content, string privateKeyPem, string charset, string signType, bool keyFromFile)
        {
            if (keyFromFile)
            {
                ArgumentValidator.CheckArgument(!String.IsNullOrEmpty(privateKeyPem), "私钥文件路径不可为空。");
                privateKeyPem = LoadPrivateKeyFromRSACertFile(privateKeyPem);
            }

            return AsymmetricManager.GetByName(signType).Decrypt(content, charset, privateKeyPem);
        }

        private static string LoadPrivateKeyFromRSACertFile(string filename)
        {
            using (FileStream fs = File.OpenRead(filename))
            {
                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, data.Length);
                if (data[0] != 0x30)
                {
                    return GetPem("RSA PRIVATE KEY", data);
                }
                throw new AopException("证书文件格式不符合预期，无法提取私钥。");
            }
        }

        private static string GetPem(string type, byte[] data)
        {
            string pem = Encoding.UTF8.GetString(data);
            string header = String.Format("-----BEGIN {0}-----\\n", type);
            string footer = String.Format("-----END {0}-----", type);
            int start = pem.IndexOf(header, StringComparison.Ordinal) + header.Length;
            int end = pem.IndexOf(footer, start, StringComparison.Ordinal);

            return pem.Substring(start, (end - start));
        }

        public static SignSourceData ExtractSignContent(String str, int begin)
        {
            if (str == null)
            {
                return null;
            }

            int beginIndex = ExtractBeginPosition(str, begin);
            if (beginIndex >= str.Length)
            {
                return null;
            }

            int endIndex = ExtractEndPosition(str, beginIndex);
            return new SignSourceData()
            {
                SourceData = str.Substring(beginIndex, endIndex - beginIndex),
                BeginIndex = beginIndex,
                EndIndex = endIndex
            };
        }

        private static int ExtractBeginPosition(String responseString, int begin)
        {
            int beginPosition = begin;
            //找到第一个左大括号（对应响应的是JSON对象的情况：普通调用OpenAPI响应明文）
            //或者双引号（对应响应的是JSON字符串的情况：加密调用OpenAPI响应Base64串），作为待验签内容的起点
            while (beginPosition < responseString.Length
                    && responseString[beginPosition] != '{'
                    && responseString[beginPosition] != '"')
            {
                ++beginPosition;
            }
            return beginPosition;
        }

        private static int ExtractEndPosition(String responseString, int beginPosition)
        {
            //提取明文验签内容终点
            if (responseString[beginPosition] == '{')
            {
                return ExtractJsonObjectEndPosition(responseString, beginPosition);
            }
            //提取密文验签内容终点
            else
            {
                return ExtractJsonBase64ValueEndPosition(responseString, beginPosition);
            }
        }

        private static int ExtractJsonBase64ValueEndPosition(String responseString, int beginPosition)
        {
            for (int index = beginPosition; index < responseString.Length; ++index)
            {
                //找到第2个双引号作为终点，由于中间全部是Base64编码的密文，所以不会有干扰的特殊字符
                if (responseString[index] == '"' && index != beginPosition)
                {
                    return index + 1;
                }
            }
            //如果没有找到第2个双引号，说明验签内容片段提取失败，直接尝试选取剩余整个响应字符串进行验签
            return responseString.Length;
        }

        private static int ExtractJsonObjectEndPosition(String responseString, int beginPosition)
        {
            //记录当前尚未发现配对闭合的大括号
            LinkedList<String> braces = new LinkedList<String>();
            //记录当前字符是否在双引号中
            bool inQuotes = false;
            //记录当前字符前面连续的转义字符个数
            int consecutiveEscapeCount = 0;
            //从待验签字符的起点开始遍历后续字符串，找出待验签字符串的终止点，终点即是与起点{配对的}
            for (int index = beginPosition; index < responseString.Length; ++index)
            {
                //提取当前字符
                char currentChar = responseString[index];

                //如果当前字符是"且前面有偶数个转义标记（0也是偶数）
                if (currentChar == '"' && consecutiveEscapeCount % 2 == 0)
                {
                    //是否在引号中的状态取反
                    inQuotes = !inQuotes;
                }
                //如果当前字符是{且不在引号中
                else if (currentChar == '{' && !inQuotes)
                {
                    //将该{加入未闭合括号中
                    braces.AddLast("{");
                }
                //如果当前字符是}且不在引号中
                else if (currentChar == '}' && !inQuotes)
                {
                    //弹出一个未闭合括号
                    braces.RemoveLast();
                    //如果弹出后，未闭合括号为空，说明已经找到终点
                    if (braces.Count == 0)
                    {
                        return index + 1;
                    }
                }

                //如果当前字符是转义字符
                if (currentChar == '\\')
                {
                    //连续转义字符个数+1
                    ++consecutiveEscapeCount;
                }
                else
                {
                    //连续转义字符个数置0
                    consecutiveEscapeCount = 0;
                }
            }

            //如果没有找到配对的闭合括号，说明验签内容片段提取失败，直接尝试选取剩余整个响应字符串进行验签
            return responseString.Length;
        }

        /// <summary>
        /// 获取公钥证书序列号
        /// </summary>
        /// <param name="certPath">公钥证书路径</param>
        /// <returns>公钥证书序列号</returns>
        public static String GetCertSN(String certPath)
        {
            X509Certificate cert = AntCertificationUtil.ParseCert(File.ReadAllText(certPath));
            return AntCertificationUtil.GetCertSN(cert);
        }


        [Obsolete("因之前方法命名不符合C#规范而废弃的方法，请替换为EncryptAndSign方法")]
        public static string encryptAndSign(string bizContent, string alipayPublicKey, string cusPrivateKey, string charset,
           bool isEncrypt, bool isSign, string signType, bool keyFromFile)
        {
            return EncryptAndSign(bizContent, alipayPublicKey, cusPrivateKey, charset, isEncrypt, isSign, signType, keyFromFile);
        }

        [Obsolete("请替换为EncryptAndSign方法，显式设置参数：signTyp=RSA，keyFromFile=true")]
        public static string encryptAndSign(string bizContent, string alipayPublicKey, string cusPrivateKey, string charset,
            bool isEncrypt, bool isSign)
        {
            return EncryptAndSign(bizContent, alipayPublicKey, cusPrivateKey, charset, isEncrypt, isSign, "RSA", true);
        }

        [Obsolete("请替换为未废弃的有完整参数列表的重载版本，明确指定各参数的值")]
        public static string CheckSignAndDecrypt(IDictionary<string, string> parameters, string alipayPublicKey,
                                             string cusPrivateKey, bool isCheckSign, bool isDecrypt)
        {
            return CheckSignAndDecrypt(parameters, alipayPublicKey, cusPrivateKey, isCheckSign, isDecrypt, "RSA", true);
        }

        [Obsolete("请替换为未废弃的有完整参数列表的重载版本，明确指定各参数的值")]
        public static string RSASign(IDictionary<string, string> parameters, string privateKeyPem, string charset, string signType)
        {
            string signContent = GetSignContent(parameters);

            return RSASignCharSet(signContent, privateKeyPem, charset, signType);
        }

        [Obsolete("请替换为未废弃的有完整参数列表的重载版本，明确指定各参数的值")]
        public static string RSASign(string data, string privateKeyPem, string charset, string signType)
        {
            return RSASignCharSet(data, privateKeyPem, charset, signType);
        }

        [Obsolete("请替换为未废弃的有完整参数列表的重载版本，按照惯例将keyFromFile参数列在最后")]
        public static string RSASign(IDictionary<string, string> parameters, string privateKey, string charset, bool keyFromFile, string signType)
        {
            string signContent = GetSignContent(parameters);
            return RSASignCharSet(signContent, privateKey, charset, signType, keyFromFile);
        }

        [Obsolete("请替换为未废弃的有完整参数列表的重载版本，明确指定各参数的值")]
        public static string RSASignCharSet(string data, string privateKeyPem, string charset, string signType)
        {
            return RSASignCharSet(data, privateKeyPem, charset, signType, true);
        }

        [Obsolete("请替换为未废弃的有完整参数列表的重载版本，明确指定各参数的值")]
        public static bool RSACheckV1(IDictionary<string, string> parameters, string publicKeyPem, string charset)
        {
            string sign = parameters["sign"];

            parameters.Remove("sign");
            parameters.Remove("sign_type");
            string signContent = GetSignContent(parameters);
            return RSACheckContent(signContent, sign, publicKeyPem, charset, "RSA");
        }

        [Obsolete("请替换为未废弃的有完整参数列表的重载版本，明确指定各参数的值")]
        public static bool RSACheckV1(IDictionary<string, string> parameters, string publicKeyPem)
        {
            string sign = parameters["sign"];

            parameters.Remove("sign");
            parameters.Remove("sign_type");
            string signContent = GetSignContent(parameters);

            return RSACheckContent(signContent, sign, publicKeyPem, DEFAULT_CHARSET, "RSA");
        }

        [Obsolete("请替换为未废弃的有完整参数列表的重载版本，明确指定各参数的值")]
        public static bool RSACheckV2(IDictionary<string, string> parameters, string publicKeyPem)
        {
            string sign = parameters["sign"];

            parameters.Remove("sign");
            string signContent = GetSignContent(parameters);

            return RSACheckContent(signContent, sign, publicKeyPem, DEFAULT_CHARSET, "RSA");
        }

        [Obsolete("请替换为未废弃的有完整参数列表的重载版本，明确指定各参数的值")]
        public static bool RSACheckV2(IDictionary<string, string> parameters, string publicKeyPem, string charset)
        {
            string sign = parameters["sign"];

            parameters.Remove("sign");
            string signContent = GetSignContent(parameters);

            return RSACheckContent(signContent, sign, publicKeyPem, charset, "RSA");
        }

        [Obsolete("请替换为未废弃的有完整参数列表的重载版本，明确指定各参数的值")]
        public static bool RSACheckContent(string signContent, string sign, string publicKeyPem, string charset, string signType)
        {
            return RSACheckContent(signContent, sign, publicKeyPem, charset, signType, true);
        }

        [Obsolete("请替换为未废弃的有完整参数列表的重载版本，明确指定各参数的值")]
        public static bool RSACheckContent(string signContent, string sign, string publicKeyPem, string charset, bool keyFromFile)
        {
            return RSACheckContent(signContent, sign, publicKeyPem, charset, "RSA", keyFromFile);
        }

        [Obsolete("请替换为未废弃的有完整参数列表的重载版本，明确指定各参数的值")]
        public static string RSAEncrypt(string content, string publicKeyPem, string charset)
        {
            return RSAEncrypt(content, publicKeyPem, charset, true);
        }

        [Obsolete("请替换为未废弃的有完整参数列表的重载版本，明确指定各参数的值")]
        public static string RSADecrypt(string content, string privateKeyPem, string charset, string signType)
        {
            return RSADecrypt(content, privateKeyPem, charset, signType, true);
        }
    }
}
