﻿using System.Net;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using BackendProject.Models;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;

namespace BackendProject.Controllers
{
    [ApiController]
    [Route("doctor")]
    public class DoctorController : ControllerBase
    {
        private readonly ILogger<DoctorController> _logger;

        public DoctorController(ILogger<DoctorController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [HttpGet("all")]
        [Authorize(Roles = "RECP")]
        public List<DoctorModel> All()
        {
            using var db = new DatabaseContext();
            var result = (from x in db.Doctors
                          select new DoctorModel
                          {
                              Id = x.DoctorId,
                              Name = x.Name,
                              Lastname = x.Lastname
                          }).ToList();

            return result;
        }

        /*
            Zbiera wizyty zarejestrowane dla doktora
        */
        [HttpGet("{doctorId}/visits/registered")]
        [Authorize(Roles = "DOCT, RECP")]
        public List<VisitModel> RegisteredVisits(int doctorId)
        {
            using var db = new DatabaseContext();
            var result = (from p in db.Patients
                          join pv in db.PatientVisits on p.PatientId equals pv.PatientId
                          where pv.DoctorId == doctorId && pv.Status == "Registered"
                          select new VisitModel
                          {
                              PatientVisitId = pv.PatientVisitId,
                              Patient = new PatientModel() {
                                  PatientId = p.PatientId,
                                  Name = p.Name,
                                  Lastname = p.Lastname
                              },
                              RegisterDate = pv.RegisterDate
                          }).ToList();
            
            return result;
        }
    }
}
