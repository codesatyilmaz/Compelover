﻿using Compelover.Core.DataAccess;
using Compelover.DataAccess.EntityFrameworkCore.ContextFile;
using Compelover.DataAccess.Notional;
using Compelover.Entities.Tangible;

namespace Compelover.DataAccess.Tangible
{
    public class EfCommentDal:EfEntityRepository<Comment,CompeloverContext>,ICommentDal
    {
        
    }
}