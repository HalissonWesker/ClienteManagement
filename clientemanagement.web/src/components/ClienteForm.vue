<template>
    <div>
      <h1>{{ isEdit ? 'Editar Cliente' : 'Adicionar Cliente' }}</h1>
      <form @submit.prevent="saveCliente">
        <div>
          <label>Nome da Empresa:</label>
          <input v-model="cliente.nomeEmpresa" required />
        </div>
        <div>
          <label>Porte:</label>
          <select v-model="cliente.porte" required>
            <option>Pequena</option>
            <option>Média</option>
            <option>Grande</option>
          </select>
        </div>
        <button type="submit">Salvar</button>
      </form>
    </div>
  </template>
  
  <script>
  import axios from 'axios';
  
  export default {
    props: {
      id: String,
    },
    data() {
      return {
        cliente: {
          nomeEmpresa: '',
          porte: 'Pequena',
        },
      };
    },
    computed: {
      isEdit() {
        return !!this.id;
      },
    },
    methods: {
      async fetchCliente() {
        if (this.isEdit) {
          const response = await axios.get(`/api/cliente/${this.id}`);
          this.cliente = response.data;
        }
      },
      async saveCliente() {
        if (this.isEdit) {
          await axios.put(`/api/cliente/${this.id}`, this.cliente);
        } else {
          await axios.post('/api/cliente', this.cliente);
        }
        this.$router.push('/');
      }
    },
    mounted() {
      this.fetchCliente();
    },
  };
  </script>
  