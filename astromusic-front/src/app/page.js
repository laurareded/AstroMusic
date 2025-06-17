'use client';

import { useState } from 'react';

export default function Home() {
  const [form, setForm] = useState({
    fullName: '',
    email: '',
    birthDate: '',
  });

  const [result, setResult] = useState(null);
  const [error, setError] = useState('');

  const handleChange = (e) => {
    setForm({
      ...form,
      [e.target.name]: e.target.value,
    });
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    setError('');
    setResult(null);

    try {
      const response = await fetch('http://localhost:5029/api/User/register', {
        // Use 5001 se seu .NET tá rodando em HTTPS
        method: 'POST',
        headers: {
          'Content-Type': 'application/json',
        },
        body: JSON.stringify(form),
      });

      if (!response.ok) {
        const err = await response.text();
        setError(err);
        return;
      }

      const data = await response.json();
      setResult(data);
    } catch (err) {
      setError('Erro ao conectar com a API');
    }
  };

  return (
    <main className="min-h-screen flex flex-col items-center justify-center bg-gradient-to-br from-purple-800 to-blue-400">
      <h1 className="text-4xl font-bold mb-8 text-white drop-shadow-lg">AstroMusic</h1>
      <form
        onSubmit={handleSubmit}
        className="bg-white rounded-2xl shadow-lg p-8 flex flex-col gap-4 w-full max-w-md"
      >
        <input
          name="fullName"
          type="text"
          placeholder="Nome completo"
          value={form.fullName}
          onChange={handleChange}
          className="border p-2 rounded-xl"
          required
        />
        <input
          name="email"
          type="email"
          placeholder="E-mail"
          value={form.email}
          onChange={handleChange}
          className="border p-2 rounded-xl"
          required
        />
        <input
          name="birthDate"
          type="date"
          placeholder="Data de nascimento"
          value={form.birthDate}
          onChange={handleChange}
          className="border p-2 rounded-xl"
          required
        />
        <button
          type="submit"
          className="bg-purple-700 text-white rounded-xl py-2 font-bold hover:bg-purple-900 transition"
        >
          Consultar meu signo
        </button>
        {error && <div className="text-red-500 font-bold">{error}</div>}
      </form>

      {result && (
        <div className="mt-8 bg-white p-6 rounded-2xl shadow-xl w-full max-w-md text-center">
          <h2 className="text-2xl font-bold mb-2">{result.signName}</h2>
          <p className="mb-2">{result.description}</p>
          <p className="mb-2 font-semibold">{result.themeSong} — {result.songArtist}</p>
          <a
            href={result.songLink}
            target="_blank"
            rel="noopener noreferrer"
            className="text-purple-700 underline"
          >
            Ouvir no Spotify
          </a>
        </div>
      )}
    </main>
  );
}

