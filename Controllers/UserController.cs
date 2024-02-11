﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pizza_API.DTOs;
using Pizza_API.Helpers;
using Pizza_API.Models;
using Pizza_API.Repositories;

namespace Pizza_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IRepository<User> _repository;
        private readonly IMapper _mapper;

        public UserController(IRepository<User> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Getall()
        {
            var user = await _repository.GetAll();
            var userDTO = _mapper.Map<IEnumerable<RegisterDTO>>(user);
            return Ok(userDTO);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var user = await _repository.Get(u => u.Id == id);

            if (user == null)
                return NotFound(new
                {
                    Message = "No User has this id"
                });

            RegisterDTO userDTO = _mapper.Map<RegisterDTO>(user)!;

            return Ok(new
            {
                Message = "User found",
                User = userDTO
            });


        }

        [HttpPost]
        public async Task<IActionResult> Add([FromForm] RegisterDTO registerDTO)
        {
            var user = _mapper.Map<User>(registerDTO);

            var userAdded = await _repository.Add(user);

            //Map l'utilisateur en UserDTO et pas en register DTO pour ne pas renvoyer le mdp et le status admin
            var userAddedDTO = _mapper.Map<UserDTO>(userAdded)!;


            if (userAdded != null)
                return CreatedAtAction(nameof(GetById),
                                            new { id = userAddedDTO.Id },
                                            new
                                            {
                                                Message = "The user was added to the database",
                                                User = userAddedDTO
                                            });

            return BadRequest("Oops something went wrong");

        }




    }
}