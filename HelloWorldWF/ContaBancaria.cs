using System;

public class ContaBancaria
    {
        private string m_nomeCorrentista;

        private double m_saldo;

        private bool m_bloqueio = false;

        private ContaBancaria()
        {
        }

        public ContaBancaria(string nomeCorrentista, double saldo)
        {
        if (saldo < 0) throw new Exception("Saldo não pode ser menor que zero");
            m_nomeCorrentista = nomeCorrentista;
            m_saldo = saldo;
        }

        public string NomeCorrentista
        {
            get { return m_nomeCorrentista; }
        }

        public double Saldo
        {
            get { return m_saldo; }
        }

        public void Debito(double montante)
        {
            if (m_bloqueio)
            {
                throw new Exception("Conta bloqueada");
            }

            if (montante > m_saldo)
            {
                throw new ArgumentOutOfRangeException("Montante maior que Saldo");
            }

            if (montante < 0)
            {
                throw new ArgumentOutOfRangeException("Montante menor que zero.");
            }

            m_saldo -= montante; // inserido erro de codigo  
        }

        public void Credito(double montante)
        {
            if (m_bloqueio)
            {
                throw new Exception("Conta bloqueada");
            }

            if (montante < 0)
            {
                throw new ArgumentOutOfRangeException("Montante menor que zero");
            }

            m_saldo += montante;
        }

        private void BloquearConta()
        {
            m_bloqueio = true;
        }

        private void DesbloqueiaConta()
        {
            m_bloqueio = false;
        }
    }