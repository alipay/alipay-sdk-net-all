using System.IO;
using Org.BouncyCastle.X509;
using System.Collections.Generic;
using System;
using System.Text;
using System.Linq;

namespace Aop.Api.Util
{
    public class CertEnvironment
    {
        /// <summary>
        /// 支付宝根证书内容，用于验证下载的支付宝公钥证书有效性
        /// </summary>
        public string RootCertContent { get; set; }

        /// <summary>
        /// 支付宝根证书序列号，用于每次调动OpenAPI时发送给网关
        /// </summary>
        public string RootCertSN { get; set; }

        /// <summary>
        /// 商户证书序列号，用于每次调动OpenAPI时发送给网关
        /// </summary>
        public string AppCertSN { get; set; }

        /// <summary>
        /// 不同支付宝公钥证书序列号对应的公钥内容
        /// </summary>
        private readonly Dictionary<String, String> SN2PublicKey = new Dictionary<String, String>();

        private readonly Object DictionaryLock = new Object();


        /// <summary>
        /// 初始化证书所需运行时参数
        /// </summary>
        /// <param name="certParams">用户传入的证书相关参数</param>
        /// <param name="signType">算法类型</param>
        public CertEnvironment(CertParams certParams, string signType)
        {
            //解析支付宝根证书序列号
            this.RootCertContent = File.ReadAllText(certParams.RootCertPath);
            this.RootCertSN = AntCertificationUtil.GetRootCertSN(RootCertContent, signType);

            //解析应用证书序列号
            X509Certificate appCert = AntCertificationUtil.ParseCert(File.ReadAllText(certParams.AppCertPath));
            this.AppCertSN = AntCertificationUtil.GetCertSN(appCert);

            //解析支付宝公钥证书序列号
            X509Certificate alipayPublicKeyCert = AntCertificationUtil.ParseCert(File.ReadAllText(certParams.AlipayPublicCertPath));
            string alipayPublicKeyCertSN = AntCertificationUtil.GetCertSN(alipayPublicKeyCert);
            //解析支付宝公钥
            string alipayPublicKey = AntCertificationUtil.ExtractPemPublicKeyFromCert(alipayPublicKeyCert);

            //缓存支付宝公钥证书序号对应的支付宝公钥
            AddNewAlipayPublicKey(alipayPublicKeyCertSN, alipayPublicKey);
        }

        public bool ContainsAlipayPublicKey(String sn)
        {
            if (sn == null)
            {
                return false;
            }

            lock (DictionaryLock)
            {
                return SN2PublicKey.ContainsKey(sn);
            }
        }

        public string GetAlipayPublicKey(String sn)
        {
            lock (DictionaryLock)
            {
                return SN2PublicKey[sn];
            }
        }

        public void AddNewAlipayPublicKey(String sn, String alipayPublicKey)
        {
            lock (DictionaryLock)
            {
                SN2PublicKey[sn] = alipayPublicKey;
            }
        }
    }
}
