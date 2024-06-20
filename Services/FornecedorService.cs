﻿using LojaTrabalhoWeb.Data;
using LojaTrabalhoWeb.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LojaTrabalhoWeb.Services
{
    public class FornecedorService
    {
        private readonly LojaDbContext _dbContext;

        public FornecedorService(LojaDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<List<Fornecedor>> GetAllFornecedoresAsync()
        {
            return await _dbContext.Fornecedores.ToListAsync();
        }
        public async Task<Fornecedor> GetFornecedorByIdAsync(int id)
        {
            return await _dbContext.Fornecedores.FindAsync(id);
        }


        public async Task AddFornecedorAsync(Fornecedor fornecedor)
        {
            _dbContext.Fornecedores.Add(fornecedor);
            await _dbContext.SaveChangesAsync();
        }


        public async Task UpdateFornecedorAsync(Fornecedor fornecedor)
        {
            _dbContext.Entry(fornecedor).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteFornecedorAsync(int id)
        {
            var fornecedor = await _dbContext.Fornecedores.FindAsync(id);
            if (fornecedor != null)
            {
                _dbContext.Fornecedores.Remove(fornecedor);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
