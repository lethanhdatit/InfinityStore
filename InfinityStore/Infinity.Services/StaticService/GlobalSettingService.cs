using Infinity.Common;
using Infinity.Data;
using Infinity.DTOs;
using Infinity.Repositories;
using Infinity.UnitOfWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infinity.Services
{
    public class GlobalSettingModel
    {
        public string WEB_HOTLINE { get; set; }
        public string WEB_EMAIL { get; set; }
        public string WEB_ADDRESS { get; set; }
        public string WEB_DEV_ORGANIZATION { get; set; }
        public string COPYRIGHT_YEAR { get; set; }
        public string FANPAGE_FACEBOOK { get; set; }
        public string FANPAGE_TWITTER { get; set; }
        public string YOUTUBE_CHANNEL { get; set; }
        public byte CATEGORY_MAX_SUB_LEVEL { get; set; } = 2;
    }
    public class GlobalSettingService
    {
        private readonly InfinityStoreDBContext _context;
        private static GlobalSettingModel _Data = new GlobalSettingModel();
        public GlobalSettingService(InfinityStoreDBContext context)
        {
            _context = context;
            InitializeCommonData();
        }

        private void InitializeCommonData()
        {
            var data = _context.GlobalSettings.Where(x => x.Status == (byte)GlobalSettingStatus.Active);

            _Data.WEB_HOTLINE = data?.FirstOrDefault(x => x.Name.ToUpper() == "WEB_HOTLINE")?.Value;
            _Data.WEB_EMAIL = data?.FirstOrDefault(x => x.Name.ToUpper() == "WEB_EMAIL")?.Value;
            _Data.WEB_ADDRESS = data?.FirstOrDefault(x => x.Name.ToUpper() == "WEB_ADDRESS")?.Value;
            _Data.WEB_DEV_ORGANIZATION = data?.FirstOrDefault(x => x.Name.ToUpper() == "WEB_DEV_ORGANIZATION")?.Value;
            _Data.COPYRIGHT_YEAR = data?.FirstOrDefault(x => x.Name.ToUpper() == "COPYRIGHT_YEAR")?.Value;
            _Data.FANPAGE_FACEBOOK = data?.FirstOrDefault(x => x.Name.ToUpper() == "FANPAGE_FACEBOOK")?.Value;
            _Data.FANPAGE_TWITTER = data?.FirstOrDefault(x => x.Name.ToUpper() == "FANPAGE_TWITTER")?.Value;
            _Data.YOUTUBE_CHANNEL = data?.FirstOrDefault(x => x.Name.ToUpper() == "YOUTUBE_CHANNEL")?.Value;
            try { _Data.CATEGORY_MAX_SUB_LEVEL = byte.Parse(data?.FirstOrDefault(x => x.Name.ToUpper() == "CATEGORY_MAX_SUB_LEVEL")?.Value); } catch { }
        }
        public void FetchData()
        {
            InitializeCommonData();
        }
        public GlobalSettingModel Get()
        {
            if (_Data == null) InitializeCommonData();
            return _Data;
        }
    }
}
