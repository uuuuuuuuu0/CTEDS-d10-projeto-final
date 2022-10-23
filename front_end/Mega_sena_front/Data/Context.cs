using Microsoft.EntityFrameworkCore;
using System;

namespace Mega_sena_front.Data
{
    public class Context : DbContext
    {
		public Context(DbContextOptions<Context> options) : base(options)
		{
			Database.EnsureCreated();
		}

		public DbSet<MegaSena> megaSenas { get; set; }
		public DbSet<LotoFacil> lotoFacils { get; set; }
		public DbSet<Quina> quinas { get; set; }
		public DbSet<Lotomania> lotomanias { get; set; }
		public DbSet<DuplaSena> duplaSenas { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<MegaSena>().HasData(DataGenerator.MegaSenas(30));
			modelBuilder.Entity<LotoFacil>().HasData(DataGenerator.LotoFacils(30));
            modelBuilder.Entity<Quina>().HasData(DataGenerator.Quinas(30));
            modelBuilder.Entity<DuplaSena>().HasData(DataGenerator.DuplaSenas(30));

            base.OnModelCreating(modelBuilder);
		}

		private static MegaSena[] GetMegaSenas()
		{
			return new MegaSena[]
			{
                new MegaSena
                {
                    Id = 1,
                    Prize = 1000000.00,
                    StartTime = new DateTime(2019, 12, 1),
                    EndTime = new DateTime(2019, 12, 31),
                    Status = "Encerrada",
                    Result = "010203040506"
                },
                new MegaSena
                {
                    Id = 2,
                    Prize = 1200000.00,
                    StartTime = new DateTime(2022, 10, 1),
                    EndTime = new DateTime(2022, 10, 31),
                    Status = "Aberta"
                },
                new MegaSena
                {
                    Id = 3,
                    Prize = 1200000.00,
                    StartTime = new DateTime(2022, 10, 1),
                    EndTime = new DateTime(2022, 10, 14),
                    Status = "Encerrada",
                    Result = "112233445560"
                }
            };
		}
        private static LotoFacil[] GetLotoFacils()
        {
            return new LotoFacil[]
            {
                new LotoFacil
                {
                    Id = 1,
                    Prize = 111111.00,
                    StartTime = new DateTime(2010, 12, 1),
                    EndTime = new DateTime(2011, 12, 31),
                    Status = "Encerrada",
                    Result = "010203040506070809101112131415"
                },
                new LotoFacil
                {
                    Id = 2,
                    Prize = 121111.00,
                    StartTime = new DateTime(2024, 10, 1),
                    EndTime = new DateTime(2026, 10, 31),
                    Status = "Aberta"
                },
                new LotoFacil
                {
                    Id = 3,
                    Prize = 121111.00,
                    StartTime = new DateTime(2020, 10, 1),
                    EndTime = new DateTime(2021, 10, 14),
                    Status = "Encerrada",
                    Result = "111213141516171819202122232425"
                }
            };
        }

        public static Quina[] GetQuinas()
        {
            return new Quina[]
            {
                new Quina
                {
                    Id = 1,
                    Prize = 1000000.00,
                    StartTime = new DateTime(2010, 12, 1),
                    EndTime = new DateTime(2011, 12, 31),
                    Status = "Encerrada",
                    Result = "0821546076"
                },
                new Quina
                {
                    Id = 2,
                    Prize = 1250000.00,
                    StartTime = new DateTime(2024, 10, 1),
                    EndTime = new DateTime(2026, 10, 31),
                    Status = "Aberta"
                },
                new Quina
                {
                    Id = 3,
                    Prize = 780000.00,
                    StartTime = new DateTime(2020, 10, 1),
                    EndTime = new DateTime(2021, 10, 14),
                    Status = "Encerrada",
                    Result = "1112256071"
                }
            };
        }

        private static DuplaSena[] GetDuplaSenas()
        {
            return new DuplaSena[]
            {
                new DuplaSena
                {
                    Id = 1,
                    Prize = 1000000.00,
                    StartTime = new DateTime(2010, 12, 1),
                    EndTime = new DateTime(2011, 12, 31),
                    Status = "Encerrada",
                    Result = "081521334650031416344048"
                },
                new DuplaSena
                {
                    Id = 2,
                    Prize = 1250000.00,
                    StartTime = new DateTime(2024, 10, 1),
                    EndTime = new DateTime(2026, 10, 31),
                    Status = "Aberta"
                },
                new DuplaSena
                {
                    Id = 3,
                    Prize = 780000.00,
                    StartTime = new DateTime(2020, 10, 1),
                    EndTime = new DateTime(2021, 10, 14),
                    Status = "Encerrada",
                    Result = "060718273542010326313744"
                }
            };
        }
    }
}
