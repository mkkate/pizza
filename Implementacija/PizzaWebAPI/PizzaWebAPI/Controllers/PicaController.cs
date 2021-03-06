﻿using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaDatabaseAccess;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaDatabaseAccess.DTOs;

namespace PizzaWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PicaController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiPice")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPice()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSvePice());
            }
            catch (Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiPicu/{picaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPica(int picaID)
        {
            try
            {
                return new JsonResult(DataProvider.VratiPicu(picaID));
            }
            catch (Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }

        [HttpPost]
        [Route("DodajPicu")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddPica([FromBody] PicaView p)
        {
            try
            {
                DataProvider.DodajPicu(p);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiPicu/{picaID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeletePica(int picaID)
        {
            try
            {
                DataProvider.ObrisiPicu(picaID);
                return Ok();
            }
            catch (Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniPicu")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangePica([FromBody] PicaView p)
        {
            try
            {
                DataProvider.IzmeniPicu(p);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
