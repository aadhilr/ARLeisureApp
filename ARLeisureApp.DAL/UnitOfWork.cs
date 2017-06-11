using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARLeisureApp.Domain.LocationModels;

namespace ARLeisureApp.DAL
{
   public class UnitOfWork : IDisposable
   {
       private readonly LeisureContext _context =new LeisureContext();

       #region Location Repositories

       private GenericRepository<Location> _locationRepository;
       private GenericRepository<LocationCategory> _locationCategoryRepository;
       private GenericRepository<LocationImage> _locationImageRepository;
       private GenericRepository<LocationArticle> _locationArticlerRepository;

       public GenericRepository<Location> LocationRepository
       {
           get
           {
               if (this._locationRepository == null)
               {
                   this._locationRepository = new GenericRepository<Location>(_context);
               }
               return _locationRepository;
           }
        }

       public GenericRepository<LocationCategory> LocationCategoryRepository
       {
           get
           {
               if (this._locationCategoryRepository == null)
               {
                   this._locationCategoryRepository = new GenericRepository<LocationCategory>(_context);
               }
               return _locationCategoryRepository;
           }
       }

       public GenericRepository<LocationImage> LocationImageRepository
       {
           get
           {
               if (this._locationImageRepository == null)
               {
                   this._locationImageRepository = new GenericRepository<LocationImage>(_context);
               }
               return _locationImageRepository;
           }
       }

       public GenericRepository<LocationArticle> LocationArticleRepository
       {
           get
           {
               if (this._locationArticlerRepository == null)
               {
                   this._locationArticlerRepository = new GenericRepository<LocationArticle>(_context);
               }
               return _locationArticlerRepository;
           }
       }

        #endregion

        public void Save()
       {
           _context.SaveChanges();
       }

       private bool _disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this._disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
