using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public enum JobType { Warrior, Mage, Thief }

    public class Player
    {
        public JobType jobType;

        public int playerHp, playerMp, playerAttack;
        public int playerLevel, playerExp;
        public int MaxHp, MaxMp, MaxExp;

        public int gold;
        public int bonusExp;

        public List<Skill> skills = new List<Skill>();

        public void SelectJob()
        {
            while (true) {
                Console.Clear();
                Console.Write("직업 선택 (1. 검사 2. 마법사 3. 도적) : ");
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1: SetPlayer(JobType.Warrior, 120, 10, 10); break;
                    case 2: SetPlayer(JobType.Mage, 70, 30, 7); break;
                    case 3: SetPlayer(JobType.Thief, 90, 25, 8); break;
                }
                Console.WriteLine();
                ShowInfo();

                Console.Write("\n직업을 선택하시겠습니까? 1.예 2.아니오   ");
                input = int.Parse(Console.ReadLine());
                if (input == 1) break;
            }
        }

        void SetPlayer(JobType job, int hp, int mp, int atk)
        {
            jobType = job;

            MaxHp = hp;
            MaxMp = mp;
            playerHp = hp;
            playerMp = mp;
            playerAttack = atk;

            playerLevel = 1;
            playerExp = 0;
            MaxExp = 5;
            gold = 0;

            skills.Clear();

            switch (jobType)
            {
                case JobType.Warrior:
                    skills.Add(new Skill("강타", 5, 2));
                    skills.Add(new Skill("회전베기", 10, 3));
                    break;

                case JobType.Mage:
                    skills.Add(new Skill("파이어볼", 8, 3));
                    skills.Add(new Skill("메테오", 15, 5));
                    break;

                case JobType.Thief:
                    skills.Add(new Skill("기습", 6, 2));
                    skills.Add(new Skill("연속베기", 12, 4));
                    break;
            }
        }

        public int UseSkill(int index)
        {
            if (index < 0 || index >= skills.Count)
                return 0;

            return skills[index].Use(this);
        }

        public void GainExp(int exp)
        {
            playerExp += exp + bonusExp;
            if (playerExp >= MaxExp)
            {
                playerLevel++;
                playerExp -= MaxExp;
                MaxExp += 5;
                playerAttack += 2;
                MaxHp += 10;
                MaxMp += 5;
                playerHp = MaxHp;
                playerMp = MaxMp;
                Console.WriteLine("⭐ 레벨업!");
            }
        }

        public void PlayerDamaged(int dmg) => playerHp -= dmg;
        public bool IsDead() => playerHp <= 0;

        public void Die()
        {
            Console.WriteLine("플레이어 사망...");
            playerHp = 1;
            playerExp = 0;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"직업 : {jobType}");
            Console.WriteLine($"HP : {playerHp}/{MaxHp}  MP : {playerMp}/{MaxMp}");
            Console.WriteLine($"ATK : {playerAttack}  LV : {playerLevel}");
            Console.WriteLine($"EXP : {playerExp}/{MaxExp}  Gold : {gold}");
        }
    }
}
