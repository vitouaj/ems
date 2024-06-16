<template>
    <v-row>
      <v-col cols="12" class="d-flex justify-center pb-0">
        <span class="text-caption" style="color:#FF7F00">{{ session.title }}</span>
      </v-col>
      <v-col cols="12" class="py-0">
        <label for="eventName" class="labelText">Title</label><br />
        <v-text-field
          v-model="localSession.title"
          placeholder="e.g name of session"
        ></v-text-field>
      </v-col>
      <v-col cols="6" class="py-0">
        <label for="eventName" class="labelText">Date</label><br />
        <v-text-field
          v-model="localSession.date"
          placeholder="Date of session"
        ></v-text-field>
      </v-col>
      <v-col cols="6" class="py-0">
        <label for="StartDate" class="labelText">Start Time</label><br />
        <v-text-field
          v-model="localSession.start_time"
          placeholder="HH/MM/SS"
        ></v-text-field>
      </v-col>
      <v-col cols="6"></v-col>
      <v-col cols="6" class="py-0">
        <label for="EndDate" class="labelText">End Time</label><br />
        <v-text-field
          v-model="localSession.end_time"
          placeholder="HH/MM/SS"
        ></v-text-field>
      </v-col>
      <v-col cols="12" class="py-0">
        <label for="EndDate" class="labelText">Description</label><br />
        <v-textarea
          v-model="localSession.description"
          variant="solo"
          row-height="20"
          rows="2"
          auto-grow
          placeholder="type your description here..."
        ></v-textarea>
      </v-col>
    </v-row>
  </template>
  
  <script>
  import TextField from './TextField.vue';
  
  export default {
    components: {
      TextField,
    },
    props: {
      session: Object,
      index: Number
    },
    data() {
      return {
        localSession: { ...this.session }
      };
    },
    watch: {
      localSession: {
        handler(newSession) {
          this.$emit('update-session', newSession);
        },
        deep: true
      }
    }
  };
  </script>
  
  <style>
  .labelText {
    color: #004B8D;
  }
  </style>
  
