using GP.Data.Infrastructure;
using GP.Domain.Entities;
using GP.ServicePattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace GP.Service
{
    public class CourseService : EntityService<Course>, ICourseService
    {
        public CourseService(IUnitOfWork _utwk,
                             IRepositoryBase<Course> _repository) : base(_utwk, _repository)
        {
        }
    }
}
