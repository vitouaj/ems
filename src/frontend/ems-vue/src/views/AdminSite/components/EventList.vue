<template>
    <v-col cols="12" class="d-flex justify-space-around pb-0">
        <v-col cols="6" class="py-0">
            <p>{{ event.name }}</p>
        </v-col>
        <v-col cols="3" class="py-0 d-flex justify-start">
            <p v-if="event.status" style="color: rgb(255, 127, 0)">ongoing</p>
            <p v-else style="color: #004B8D">ended</p>
        </v-col>
        <v-col cols="3" class="d-flex justify-end py-0">
            <p> {{ event.participators }} / {{ event.t_participators }}</p>
        </v-col>
    </v-col> 
    <!-- <p>hey</p> -->
</template>

<script>
export  default {
    props: {
      event: {
        type: Object,
        required: true
      }
    },
}
</script>
