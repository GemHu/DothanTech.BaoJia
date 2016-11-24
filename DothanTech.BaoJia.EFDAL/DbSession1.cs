//引进TT模板的命名空间
using DothanTech.BaoJia.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DothanTech.BaoJia.EFDAL
{
    public partial class DbSession
    {
		//在这里需要一个for循环来遍历数据库中所有的表放置在下面即可，这样就实现了所有的表对应的仓储显示出来了。
        public BackChannelDao BackChannelDao
        {
			get 
            {
                if (this._BackChannelDao == null)
                    this._BackChannelDao = new BackChannelDao();

                return this._BackChannelDao;
            }
        }
        private BackChannelDao _BackChannelDao;

        public BrandDao BrandDao
        {
			get 
            {
                if (this._BrandDao == null)
                    this._BrandDao = new BrandDao();

                return this._BrandDao;
            }
        }
        private BrandDao _BrandDao;

        public DeliveryAreaDao DeliveryAreaDao
        {
			get 
            {
                if (this._DeliveryAreaDao == null)
                    this._DeliveryAreaDao = new DeliveryAreaDao();

                return this._DeliveryAreaDao;
            }
        }
        private DeliveryAreaDao _DeliveryAreaDao;

        public DeliveryModeDao DeliveryModeDao
        {
			get 
            {
                if (this._DeliveryModeDao == null)
                    this._DeliveryModeDao = new DeliveryModeDao();

                return this._DeliveryModeDao;
            }
        }
        private DeliveryModeDao _DeliveryModeDao;

        public PrintColorDao PrintColorDao
        {
			get 
            {
                if (this._PrintColorDao == null)
                    this._PrintColorDao = new PrintColorDao();

                return this._PrintColorDao;
            }
        }
        private PrintColorDao _PrintColorDao;

        public ProductDao ProductDao
        {
			get 
            {
                if (this._ProductDao == null)
                    this._ProductDao = new ProductDao();

                return this._ProductDao;
            }
        }
        private ProductDao _ProductDao;

        public ProductModuleDao ProductModuleDao
        {
			get 
            {
                if (this._ProductModuleDao == null)
                    this._ProductModuleDao = new ProductModuleDao();

                return this._ProductModuleDao;
            }
        }
        private ProductModuleDao _ProductModuleDao;

        public RecommandTableDao RecommandTableDao
        {
			get 
            {
                if (this._RecommandTableDao == null)
                    this._RecommandTableDao = new RecommandTableDao();

                return this._RecommandTableDao;
            }
        }
        private RecommandTableDao _RecommandTableDao;

        public SpecialColorDao SpecialColorDao
        {
			get 
            {
                if (this._SpecialColorDao == null)
                    this._SpecialColorDao = new SpecialColorDao();

                return this._SpecialColorDao;
            }
        }
        private SpecialColorDao _SpecialColorDao;

        public TechnologyRequestDao TechnologyRequestDao
        {
			get 
            {
                if (this._TechnologyRequestDao == null)
                    this._TechnologyRequestDao = new TechnologyRequestDao();

                return this._TechnologyRequestDao;
            }
        }
        private TechnologyRequestDao _TechnologyRequestDao;

    }
}