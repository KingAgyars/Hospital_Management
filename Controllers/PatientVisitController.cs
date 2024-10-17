//using Hospital_Management.Data;
//using Hospital_Management.Models;
//using Microsoft.AspNetCore.Mvc;

//namespace Hospital_Management.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]

//    public class PatientVisitController : ControllerBase
//    {

//        private readonly PatientDbContext _context;
//        public PatientVisitController(PatientDbContext context)
//        {
//            _context = context;

//        }

//        [HttpPost]
//        public async Task<ActionResult<PatientVisit>> AddPatientVist(PatientVisitCommand patientVisit)
//        {
//            //_context.PatientVisits.Add(PatientVisitCommand);
//            await _context.SaveChangesAsync();

//            return CreatedAtAction(nameof(GetPatientVisit), new { patientVisit.Id });


//        }

//        [HttpGet("{id}")]
//        public async Task<ActionResult<PatientVisit>> GetPatientVisit(int id)
//        {
//            var patientVisit = await _context.PatientVisits.FindAsync(id);
//            if (patientVisit == null) { 
//             return NotFound();
//            }
//            else
//            {
//                return patientVisit;
//            }
//        }

//    }
//}
